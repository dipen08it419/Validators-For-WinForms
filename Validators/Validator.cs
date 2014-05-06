using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace DevSD.Windows.Forms.Validators
{
    public abstract class Validator : UserControl, IValidator
    {
        //private System.Windows.Forms.Panel panelMessageContainer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panelPointer;
        private Position _position = Position.Right;
        private PositionType _positionType = PositionType.Auto;
        private Color _pointerColor = Color.Maroon;

        private int _pointerSize = 10;
        private int _offset = 5;
        internal bool _isValid = false;
        public string _errorMessage = "Your error message goes here.";
        private Control _controlToValidate;
        private String _propertyToValidate = "Text";

        public new event ValidatingEventHandler Validating;
        public new event ValidatedEventHandler Validated;

        public Validator()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelPointer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.BackColor = System.Drawing.Color.Maroon;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(10, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblMessage.Size = new System.Drawing.Size(140, 40);
            this.lblMessage.TabIndex = 0;
            // 
            // panelPointer
            // 
            this.panelPointer.BackColor = System.Drawing.Color.Transparent;
            this.panelPointer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPointer.Location = new System.Drawing.Point(0, 0);
            this.panelPointer.Name = "panelPointer";
            this.panelPointer.Size = new System.Drawing.Size(10, 40);
            this.panelPointer.TabIndex = 1;
            this.panelPointer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPointer_Paint);
            // 
            // Validator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panelPointer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Validator";
            this.Size = new System.Drawing.Size(150, 40);
            this.ResumeLayout(false);

            this.Visible = false;
            this.Paint += Validator_Paint;
            this.BackColorChanged += Validator_BackColorChanged;
            this.ForeColorChanged += Validator_ForeColorChanged;
            this.FontChanged += Validator_FontChanged;
            this.Top = 100;
        }

        void Validator_FontChanged(object sender, EventArgs e)
        {
            this.lblMessage.Font = this.Font;
        }

        void Validator_ForeColorChanged(object sender, EventArgs e)
        {
            this.lblMessage.ForeColor = this.ForeColor;
            this.panelPointer.ForeColor = this.ForeColor;
        }

        void Validator_BackColorChanged(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Transparent)
            {
                _pointerColor = this.BackColor;
                this.lblMessage.BackColor = this.BackColor;
            }
            //this.BackColor = Color.Transparent;
        }

        private void Validator_Paint(object sender, PaintEventArgs e)
        {
            if (_controlToValidate == null || _positionType == PositionType.Fixed)
                return;

            Point _location = _controlToValidate.Location;
            if (_location != null)
            {
                if (_position == Position.Top)
                {
                    this.Location = new Point(_location.X, _location.Y - this.Height);
                }
                else if (_position == Position.Bottom)
                {
                    this.Location = new Point(_location.X, _location.Y + _controlToValidate.Height);
                }
                else if (_position == Position.Left)
                {
                    this.Location = new Point(_location.X - this.Width, _location.Y);
                }
                else if (_position == Position.Right)
                {
                    this.Location = new Point(_location.X + _controlToValidate.Width, _location.Y);
                }
            }
        }

        private void panelPointer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath path = new GraphicsPath();
            int half = _pointerSize / 2;

            if (_position == Position.Top)
            {
                path.AddPolygon(new Point[] {new Point(_offset,panelPointer.Height-_pointerSize),
                new Point(_offset+half,panelPointer.Height),
                new Point(_offset+_pointerSize,panelPointer.Height-_pointerSize)});
            }
            else if (_position == Position.Bottom)
            {
                path.AddPolygon(new Point[] {new Point(_offset,_pointerSize),
                new Point(_offset+half,0),
                new Point(_offset+_pointerSize,_pointerSize)});
            }
            else if (_position == Position.Left)
            {
                path.AddPolygon(new Point[] {new Point(panelPointer.Width-_pointerSize,_offset),
                new Point(panelPointer.Width,_offset+half),
                new Point(panelPointer.Width-_pointerSize,_offset+_pointerSize)});
            }
            else if (_position == Position.Right)
            {
                path.AddPolygon(new Point[] {new Point(_pointerSize,_offset),
                new Point(0,_offset+half),
                new Point(_pointerSize,_offset+_pointerSize)});
            }

            g.FillPath(new SolidBrush(_pointerColor), path);
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; this.lblMessage.Text = value; }
        }
        [DefaultValue(true)]
        public bool IsValid { get { return _isValid; } }
        public Control ControlToValidate
        {
            get { return _controlToValidate; }
            set
            {
                if (value == null)
                    throw new NoNullAllowedException();

                _controlToValidate = value;
            }
        }
        [DefaultValue("Text")]
        public String PropertyToValidate
        {
            get { return _propertyToValidate; }
            set
            {
                if (value == null)
                    throw new NoNullAllowedException();

                PropertyInfo info = _controlToValidate.GetType().GetProperty(value);
                if (info == null)
                    throw new Exception("Invalid property value.");
                else
                    _propertyToValidate = value;
            }
        }
        public bool ShowExceptions { get; set; }
        public Position Position
        {
            get { return _position; }
            set
            {
                _position = value;
                UpdateUI();
            }
        }
        public PositionType PositionType
        {
            get { return _positionType; }
            set
            {
                _positionType = value;
                this.InvokePaint(this, new PaintEventArgs(this.CreateGraphics(), new Rectangle(0, 0, this.Width, this.Height)));
            }
        }
        public int PointerSize
        {
            get { return _pointerSize; }
            set
            {
                if (value > 0)
                {
                    _pointerSize = value;
                    UpdateUI();
                }
            }
        }
        public int PointerOffset
        {
            get { return _offset; }
            set
            {
                if (value > 0)
                {
                    _offset = value;
                    UpdateUI();
                }
            }
        }

        private void UpdateUI()
        {
            if (_position == Position.Top)
            {
                panelPointer.Dock = DockStyle.Bottom;
            }
            else if (_position == Position.Bottom)
            {
                panelPointer.Dock = DockStyle.Top;
            }
            else if (_position == Position.Left)
            {
                panelPointer.Dock = DockStyle.Right;
            }
            else if (_position == Position.Right)
            {
                panelPointer.Dock = DockStyle.Left;
            }
            panelPointer.Size = new Size(PointerSize, PointerSize);
        }

        public abstract bool Validate();

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Validator
            // 
            this.Name = "Validator";
            this.ResumeLayout(false);

        }
    }

    public enum Position { Top, Left, Right, Bottom };
    public enum PositionType { Auto, Fixed };
}
