using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Enum;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.View.Control;
using SupplyDispense.View.Dialog;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Sheet
{
    public class BaseSheet : UserControl, ISheet
    {
        private readonly OptionsType _controlOption;

        private readonly Dictionary<OptionsType, Action<BaseSheet>> _optionMap
            = new Dictionary<OptionsType, Action<BaseSheet>>
                  {
                      {OptionsType.Full, bs => bs.Options.Show()},
                      {OptionsType.Printer, bs => bs.PrintScreenOnly.Show()},
                      {OptionsType.None, _ => { }}
                  };

        protected ConnectionInfoControl ConnectionInfo;
        protected DefaultOptionControl Options;
        protected PrintScreenOnly PrintScreenOnly;

        private Button _mainMenuBtn;
        private PictureBox logo;

        public BaseSheet() : this(new BaseModel())
        {
        }

        protected BaseSheet(BaseModel model, OptionsType options = OptionsType.Full)
        {
            InitializeComponent();
            ConnectionInfo.Initialize(model);
            Options.Initialize(model);
            if (options == OptionsType.Printer) PrintScreenOnly.Initialize(model);
            Options.Hide();
            PrintScreenOnly.Hide();
            _controlOption = options;
            Height = 600;
            Width = 800;
            ToggleControls();
            model.MainMenuRequest = _mainMenuBtn.GetClick().Select(__ => model);
            logo.GetClick().Subscribe(_ => new AboutDialog().ShowDialog());
        }

        #region ISheet Members

        public ISheet ToggleControls()
        {
            Options.Hide();
            PrintScreenOnly.Hide();
            _optionMap[_controlOption](this);
            return this;
        }

        #endregion

        public UserControl ExposeControl()
        {
            return this;
        }

        private void InitializeComponent()
        {
            Options = new DefaultOptionControl();
            PrintScreenOnly = new PrintScreenOnly();
            ConnectionInfo = new ConnectionInfoControl();
            logo = new PictureBox();
            _mainMenuBtn = new Button();
            ((ISupportInitialize) (logo)).BeginInit();
            SuspendLayout();
            // 
            // Options
            // 
            Options.Location = new Point(633, 13);
            Options.Name = "Options";
            Options.Size = new Size(148, 143);
            Options.TabIndex = 0;
            // 
            // PrintScreenOnly
            // 
            PrintScreenOnly.Location = new Point(631, 13);
            PrintScreenOnly.Name = "PrintScreenOnly";
            PrintScreenOnly.Size = new Size(150, 102);
            PrintScreenOnly.TabIndex = 1;
            // 
            // ConnectionInfo
            // 
            ConnectionInfo.BackColor = Color.Transparent;
            ConnectionInfo.Location = new Point(12, 527);
            ConnectionInfo.Name = "ConnectionInfo";
            ConnectionInfo.Size = new Size(150, 61);
            ConnectionInfo.TabIndex = 2;
            // 
            // logo
            // 
            logo.Location = new Point(12, 13);
            logo.Name = "logo";
            logo.Size = new Size(499, 126);
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // mainMenuBtn
            // 
            _mainMenuBtn.Location = new Point(517, 18);
            _mainMenuBtn.Name = "_mainMenuBtn";
            _mainMenuBtn.Size = new Size(110, 38);
            _mainMenuBtn.TabIndex = 4;
            _mainMenuBtn.Text = Master.MainMenuButton;
            _mainMenuBtn.UseVisualStyleBackColor = true;
            // 
            // BaseSheet
            // 
            Controls.Add(_mainMenuBtn);
            Controls.Add(logo);
            Controls.Add(ConnectionInfo);
            Controls.Add(PrintScreenOnly);
            Controls.Add(Options);
            Name = "BaseSheet";
            Size = new Size(800, 600);
            ((ISupportInitialize) (logo)).EndInit();
            ResumeLayout(false);
        }
    }
}