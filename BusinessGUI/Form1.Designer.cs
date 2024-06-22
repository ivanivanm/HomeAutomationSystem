
namespace BusinessGUI
{
    partial class HomeAutomationControllerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbHome = new TextBox();
            lbHome = new Label();
            tbR1Type = new TextBox();
            tbHomeRoom1 = new TextBox();
            tbHomeRoom2 = new TextBox();
            lbTvName = new Label();
            tbTvName = new TextBox();
            pR1TV = new Panel();
            btnIsTvOn = new Button();
            btnTvNightMode = new Button();
            lbIsTvOn = new Label();
            lbTvLightFactor = new Label();
            lbTvVolume = new Label();
            lbTvNightMode = new Label();
            lbTvNameHint = new Label();
            pR1Fridge = new Panel();
            lbFridgeName = new Label();
            lbFridgeNameHint = new Label();
            lbIsFridgeOn = new Label();
            btnIsFridgeOn = new Button();
            lbFridgeTemperature = new Label();
            lbFridgeEnergyEffect = new Label();
            btnFridgeEnergyEffect = new Button();
            lbFridgeSmartCooling = new Label();
            btnFridgeSmartCooling = new Button();
            pR2L = new Panel();
            lbACSpeed = new Label();
            lbACSelfCleaning = new Label();
            btnACSelfCleaning = new Button();
            lbACLateStart = new Label();
            lbACTemperature = new Label();
            lbACNameHint = new Label();
            tbACName = new TextBox();
            lbACName = new Label();
            pR2AC = new Panel();
            lbIsACOn = new Label();
            btnIsACOn = new Button();
            lbACLateStop = new Label();
            lbAcMode = new Label();
            lbACDirection = new Label();
            cbACDirection = new ComboBox();
            cbAcMode = new ComboBox();
            cbACSpeed = new ComboBox();
            tbACLateStart = new TextBox();
            tbACLateStop = new TextBox();
            lbACTurbo = new Label();
            btnACTurbo = new Button();
            lbLampLightFactor = new Label();
            btnIsLampOn = new Button();
            lbLampName = new Label();
            lbLampNameHint = new Label();
            lbIsLampOn = new Label();
            tbLampName = new TextBox();
            cbTVVolume = new ComboBox();
            cbFridgeTemperature = new ComboBox();
            cbTvLightFactor = new ComboBox();
            cbACTemperature = new ComboBox();
            lbIsRoom1On = new Label();
            btnIsRoom1On = new Button();
            lbIsRoom2On = new Label();
            btnIsRoom2On = new Button();
            tbR1Name = new TextBox();
            tbRoom2Name = new TextBox();
            tbRoom2Type = new TextBox();
            tbFridgeName = new TextBox();
            cbLampLightFactor = new ComboBox();
            SuspendLayout();
            // 
            // tbHome
            // 
            tbHome.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbHome.Location = new Point(792, 520);
            tbHome.Name = "tbHome";
            tbHome.PlaceholderText = "Enter home name";
            tbHome.Size = new Size(399, 66);
            tbHome.TabIndex = 0;
            tbHome.KeyPress += tbHome_KeyPress;
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.BorderStyle = BorderStyle.FixedSingle;
            lbHome.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbHome.Location = new Point(817, 441);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(328, 76);
            lbHome.TabIndex = 1;
            lbHome.Text = "home name";
            // 
            // tbR1Type
            // 
            tbR1Type.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbR1Type.Location = new Point(792, 239);
            tbR1Type.Name = "tbR1Type";
            tbR1Type.PlaceholderText = "Enter room type";
            tbR1Type.Size = new Size(399, 66);
            tbR1Type.TabIndex = 2;
            tbR1Type.KeyPress += tbR1Type_KeyPress;
            // 
            // tbHomeRoom1
            // 
            tbHomeRoom1.BackColor = SystemColors.MenuText;
            tbHomeRoom1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbHomeRoom1.Location = new Point(987, 324);
            tbHomeRoom1.Name = "tbHomeRoom1";
            tbHomeRoom1.Size = new Size(10, 103);
            tbHomeRoom1.TabIndex = 6;
            // 
            // tbHomeRoom2
            // 
            tbHomeRoom2.BackColor = SystemColors.MenuText;
            tbHomeRoom2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbHomeRoom2.Location = new Point(987, 603);
            tbHomeRoom2.Name = "tbHomeRoom2";
            tbHomeRoom2.Size = new Size(10, 103);
            tbHomeRoom2.TabIndex = 7;
            // 
            // lbTvName
            // 
            lbTvName.AutoSize = true;
            lbTvName.BorderStyle = BorderStyle.FixedSingle;
            lbTvName.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbTvName.Location = new Point(1438, 181);
            lbTvName.Name = "lbTvName";
            lbTvName.Size = new Size(216, 72);
            lbTvName.TabIndex = 9;
            lbTvName.Text = "tv name";
            // 
            // tbTvName
            // 
            tbTvName.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbTvName.Location = new Point(1365, 28);
            tbTvName.Name = "tbTvName";
            tbTvName.PlaceholderText = "name";
            tbTvName.Size = new Size(130, 66);
            tbTvName.TabIndex = 8;
            tbTvName.TextChanged += tbTvName_TextChanged;
            tbTvName.KeyPress += tbTvName_KeyPress;
            // 
            // pR1TV
            // 
            pR1TV.BackColor = SystemColors.ActiveCaptionText;
            pR1TV.Location = new Point(1155, 193);
            pR1TV.Name = "pR1TV";
            pR1TV.Size = new Size(239, 10);
            pR1TV.TabIndex = 10;
            // 
            // btnIsTvOn
            // 
            btnIsTvOn.Location = new Point(1572, 37);
            btnIsTvOn.Name = "btnIsTvOn";
            btnIsTvOn.Size = new Size(149, 64);
            btnIsTvOn.TabIndex = 11;
            btnIsTvOn.UseVisualStyleBackColor = true;
            btnIsTvOn.Click += btnIsTvOn_Click_1;
            // 
            // btnTvNightMode
            // 
            btnTvNightMode.Location = new Point(1547, 286);
            btnTvNightMode.Name = "btnTvNightMode";
            btnTvNightMode.Size = new Size(149, 64);
            btnTvNightMode.TabIndex = 14;
            btnTvNightMode.UseVisualStyleBackColor = true;
            btnTvNightMode.Click += btnTvNightMode_Click;
            // 
            // lbIsTvOn
            // 
            lbIsTvOn.AutoSize = true;
            lbIsTvOn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbIsTvOn.Location = new Point(1605, 117);
            lbIsTvOn.Name = "lbIsTvOn";
            lbIsTvOn.Size = new Size(65, 32);
            lbIsTvOn.TabIndex = 15;
            lbIsTvOn.Text = "Is on";
            // 
            // lbTvLightFactor
            // 
            lbTvLightFactor.AutoSize = true;
            lbTvLightFactor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbTvLightFactor.Location = new Point(1754, 263);
            lbTvLightFactor.Name = "lbTvLightFactor";
            lbTvLightFactor.Size = new Size(130, 32);
            lbTvLightFactor.TabIndex = 16;
            lbTvLightFactor.Text = "light factor";
            lbTvLightFactor.Click += lbLightF_Click;
            // 
            // lbTvVolume
            // 
            lbTvVolume.AutoSize = true;
            lbTvVolume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbTvVolume.Location = new Point(1365, 373);
            lbTvVolume.Name = "lbTvVolume";
            lbTvVolume.Size = new Size(95, 32);
            lbTvVolume.TabIndex = 17;
            lbTvVolume.Text = "Volume";
            // 
            // lbTvNightMode
            // 
            lbTvNightMode.AutoSize = true;
            lbTvNightMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbTvNightMode.Location = new Point(1549, 373);
            lbTvNightMode.Name = "lbTvNightMode";
            lbTvNightMode.Size = new Size(144, 32);
            lbTvNightMode.TabIndex = 18;
            lbTvNightMode.Text = "Night Mode";
            // 
            // lbTvNameHint
            // 
            lbTvNameHint.AutoSize = true;
            lbTvNameHint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbTvNameHint.Location = new Point(1378, 110);
            lbTvNameHint.Name = "lbTvNameHint";
            lbTvNameHint.Size = new Size(110, 32);
            lbTvNameHint.TabIndex = 19;
            lbTvNameHint.Text = "TV name";
            // 
            // pR1Fridge
            // 
            pR1Fridge.BackColor = SystemColors.ActiveCaptionText;
            pR1Fridge.Location = new Point(560, 193);
            pR1Fridge.Name = "pR1Fridge";
            pR1Fridge.Size = new Size(239, 10);
            pR1Fridge.TabIndex = 20;
            // 
            // lbFridgeName
            // 
            lbFridgeName.AutoSize = true;
            lbFridgeName.BorderStyle = BorderStyle.FixedSingle;
            lbFridgeName.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFridgeName.Location = new Point(228, 157);
            lbFridgeName.Name = "lbFridgeName";
            lbFridgeName.Size = new Size(309, 72);
            lbFridgeName.TabIndex = 21;
            lbFridgeName.Text = "fridge name";
            // 
            // lbFridgeNameHint
            // 
            lbFridgeNameHint.AutoSize = true;
            lbFridgeNameHint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFridgeNameHint.Location = new Point(43, 219);
            lbFridgeNameHint.Name = "lbFridgeNameHint";
            lbFridgeNameHint.Size = new Size(148, 32);
            lbFridgeNameHint.TabIndex = 23;
            lbFridgeNameHint.Text = "Fridge name";
            // 
            // lbIsFridgeOn
            // 
            lbIsFridgeOn.AutoSize = true;
            lbIsFridgeOn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbIsFridgeOn.Location = new Point(234, 108);
            lbIsFridgeOn.Name = "lbIsFridgeOn";
            lbIsFridgeOn.Size = new Size(65, 32);
            lbIsFridgeOn.TabIndex = 25;
            lbIsFridgeOn.Text = "Is on";
            // 
            // btnIsFridgeOn
            // 
            btnIsFridgeOn.Location = new Point(199, 28);
            btnIsFridgeOn.Name = "btnIsFridgeOn";
            btnIsFridgeOn.Size = new Size(149, 64);
            btnIsFridgeOn.TabIndex = 24;
            btnIsFridgeOn.UseVisualStyleBackColor = true;
            btnIsFridgeOn.Click += btnIsFridgeOn_Click;
            // 
            // lbFridgeTemperature
            // 
            lbFridgeTemperature.AutoSize = true;
            lbFridgeTemperature.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFridgeTemperature.Location = new Point(426, 112);
            lbFridgeTemperature.Name = "lbFridgeTemperature";
            lbFridgeTemperature.Size = new Size(149, 32);
            lbFridgeTemperature.TabIndex = 27;
            lbFridgeTemperature.Text = "Temperature";
            // 
            // lbFridgeEnergyEffect
            // 
            lbFridgeEnergyEffect.AutoSize = true;
            lbFridgeEnergyEffect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFridgeEnergyEffect.Location = new Point(159, 342);
            lbFridgeEnergyEffect.Name = "lbFridgeEnergyEffect";
            lbFridgeEnergyEffect.Size = new Size(233, 32);
            lbFridgeEnergyEffect.TabIndex = 29;
            lbFridgeEnergyEffect.Text = "Energy effectiveness";
            // 
            // btnFridgeEnergyEffect
            // 
            btnFridgeEnergyEffect.Location = new Point(199, 263);
            btnFridgeEnergyEffect.Name = "btnFridgeEnergyEffect";
            btnFridgeEnergyEffect.Size = new Size(149, 64);
            btnFridgeEnergyEffect.TabIndex = 28;
            btnFridgeEnergyEffect.UseVisualStyleBackColor = true;
            btnFridgeEnergyEffect.Click += btnFridgeEnergyEffect_Click;
            // 
            // lbFridgeSmartCooling
            // 
            lbFridgeSmartCooling.AutoSize = true;
            lbFridgeSmartCooling.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFridgeSmartCooling.Location = new Point(424, 342);
            lbFridgeSmartCooling.Name = "lbFridgeSmartCooling";
            lbFridgeSmartCooling.Size = new Size(162, 32);
            lbFridgeSmartCooling.TabIndex = 31;
            lbFridgeSmartCooling.Text = "Smart cooling";
            // 
            // btnFridgeSmartCooling
            // 
            btnFridgeSmartCooling.Location = new Point(424, 263);
            btnFridgeSmartCooling.Name = "btnFridgeSmartCooling";
            btnFridgeSmartCooling.Size = new Size(149, 64);
            btnFridgeSmartCooling.TabIndex = 30;
            btnFridgeSmartCooling.UseVisualStyleBackColor = true;
            btnFridgeSmartCooling.Click += btnFridgeSmartCooling_Click;
            // 
            // pR2L
            // 
            pR2L.BackColor = SystemColors.ActiveCaptionText;
            pR2L.Location = new Point(1155, 750);
            pR2L.Name = "pR2L";
            pR2L.Size = new Size(239, 10);
            pR2L.TabIndex = 32;
            // 
            // lbACSpeed
            // 
            lbACSpeed.AutoSize = true;
            lbACSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACSpeed.Location = new Point(254, 937);
            lbACSpeed.Name = "lbACSpeed";
            lbACSpeed.Size = new Size(81, 32);
            lbACSpeed.TabIndex = 44;
            lbACSpeed.Text = "Speed";
            lbACSpeed.Click += lbACSpeed_Click;
            // 
            // lbACSelfCleaning
            // 
            lbACSelfCleaning.AutoSize = true;
            lbACSelfCleaning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACSelfCleaning.Location = new Point(210, 666);
            lbACSelfCleaning.Name = "lbACSelfCleaning";
            lbACSelfCleaning.Size = new Size(151, 32);
            lbACSelfCleaning.TabIndex = 42;
            lbACSelfCleaning.Text = "Self cleaning";
            lbACSelfCleaning.Click += label3_Click;
            // 
            // btnACSelfCleaning
            // 
            btnACSelfCleaning.Location = new Point(210, 587);
            btnACSelfCleaning.Name = "btnACSelfCleaning";
            btnACSelfCleaning.Size = new Size(149, 64);
            btnACSelfCleaning.TabIndex = 41;
            btnACSelfCleaning.UseVisualStyleBackColor = true;
            btnACSelfCleaning.Click += btnACSelfCleaning_Click;
            // 
            // lbACLateStart
            // 
            lbACLateStart.AutoSize = true;
            lbACLateStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACLateStart.Location = new Point(408, 667);
            lbACLateStart.Name = "lbACLateStart";
            lbACLateStart.Size = new Size(111, 32);
            lbACLateStart.TabIndex = 40;
            lbACLateStart.Text = "Late start";
            // 
            // lbACTemperature
            // 
            lbACTemperature.AutoSize = true;
            lbACTemperature.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACTemperature.Location = new Point(33, 937);
            lbACTemperature.Name = "lbACTemperature";
            lbACTemperature.Size = new Size(149, 32);
            lbACTemperature.TabIndex = 38;
            lbACTemperature.Text = "Temperature";
            // 
            // lbACNameHint
            // 
            lbACNameHint.AutoSize = true;
            lbACNameHint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACNameHint.Location = new Point(33, 797);
            lbACNameHint.Name = "lbACNameHint";
            lbACNameHint.Size = new Size(111, 32);
            lbACNameHint.TabIndex = 36;
            lbACNameHint.Text = "AC name";
            // 
            // tbACName
            // 
            tbACName.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbACName.Location = new Point(24, 714);
            tbACName.Name = "tbACName";
            tbACName.PlaceholderText = "name";
            tbACName.Size = new Size(130, 66);
            tbACName.TabIndex = 35;
            tbACName.KeyPress += tbACName_KeyPress;
            // 
            // lbACName
            // 
            lbACName.AutoSize = true;
            lbACName.BorderStyle = BorderStyle.FixedSingle;
            lbACName.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACName.Location = new Point(228, 735);
            lbACName.Name = "lbACName";
            lbACName.Size = new Size(238, 72);
            lbACName.TabIndex = 34;
            lbACName.Text = "AC name";
            // 
            // pR2AC
            // 
            pR2AC.BackColor = SystemColors.ActiveCaptionText;
            pR2AC.Location = new Point(710, 750);
            pR2AC.Name = "pR2AC";
            pR2AC.Size = new Size(89, 10);
            pR2AC.TabIndex = 33;
            // 
            // lbIsACOn
            // 
            lbIsACOn.AutoSize = true;
            lbIsACOn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbIsACOn.Location = new Point(59, 667);
            lbIsACOn.Name = "lbIsACOn";
            lbIsACOn.Size = new Size(65, 32);
            lbIsACOn.TabIndex = 46;
            lbIsACOn.Text = "Is on";
            // 
            // btnIsACOn
            // 
            btnIsACOn.Location = new Point(24, 587);
            btnIsACOn.Name = "btnIsACOn";
            btnIsACOn.Size = new Size(149, 64);
            btnIsACOn.TabIndex = 45;
            btnIsACOn.UseVisualStyleBackColor = true;
            btnIsACOn.Click += btnIsACOn_Click;
            // 
            // lbACLateStop
            // 
            lbACLateStop.AutoSize = true;
            lbACLateStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACLateStop.Location = new Point(573, 667);
            lbACLateStop.Name = "lbACLateStop";
            lbACLateStop.Size = new Size(111, 32);
            lbACLateStop.TabIndex = 48;
            lbACLateStop.Text = "Late stop";
            // 
            // lbAcMode
            // 
            lbAcMode.AutoSize = true;
            lbAcMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbAcMode.Location = new Point(398, 937);
            lbAcMode.Name = "lbAcMode";
            lbAcMode.Size = new Size(163, 32);
            lbAcMode.TabIndex = 50;
            lbAcMode.Text = "Choose mode";
            lbAcMode.Click += label9_Click;
            // 
            // lbACDirection
            // 
            lbACDirection.AutoSize = true;
            lbACDirection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACDirection.Location = new Point(595, 937);
            lbACDirection.Name = "lbACDirection";
            lbACDirection.Size = new Size(195, 32);
            lbACDirection.TabIndex = 52;
            lbACDirection.Text = "Choose direction";
            // 
            // cbACDirection
            // 
            cbACDirection.Enabled = false;
            cbACDirection.FormattingEnabled = true;
            cbACDirection.Items.AddRange(new object[] { "Up", "Down", "Right", "Left" });
            cbACDirection.Location = new Point(595, 875);
            cbACDirection.Name = "cbACDirection";
            cbACDirection.Size = new Size(182, 33);
            cbACDirection.TabIndex = 53;
            cbACDirection.SelectedIndexChanged += cbACDirection_SelectedIndexChanged;
            // 
            // cbAcMode
            // 
            cbAcMode.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbAcMode.Enabled = false;
            cbAcMode.FormattingEnabled = true;
            cbAcMode.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbAcMode.Location = new Point(398, 875);
            cbAcMode.Name = "cbAcMode";
            cbAcMode.Size = new Size(182, 33);
            cbAcMode.TabIndex = 54;
            cbAcMode.SelectedIndexChanged += cbAcMode_SelectedIndexChanged;
            // 
            // cbACSpeed
            // 
            cbACSpeed.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbACSpeed.Enabled = false;
            cbACSpeed.FormattingEnabled = true;
            cbACSpeed.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbACSpeed.Location = new Point(210, 875);
            cbACSpeed.Name = "cbACSpeed";
            cbACSpeed.Size = new Size(182, 33);
            cbACSpeed.TabIndex = 55;
            cbACSpeed.SelectedIndexChanged += cbACSpeed_SelectedIndexChanged;
            // 
            // tbACLateStart
            // 
            tbACLateStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbACLateStart.Location = new Point(387, 610);
            tbACLateStart.Name = "tbACLateStart";
            tbACLateStart.Size = new Size(150, 39);
            tbACLateStart.TabIndex = 56;
            tbACLateStart.KeyPress += tbACLateStart_KeyPress;
            // 
            // tbACLateStop
            // 
            tbACLateStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbACLateStop.Location = new Point(560, 612);
            tbACLateStop.Name = "tbACLateStop";
            tbACLateStop.Size = new Size(150, 39);
            tbACLateStop.TabIndex = 57;
            tbACLateStop.KeyPress += tbACLateStop_KeyPress;
            // 
            // lbACTurbo
            // 
            lbACTurbo.AutoSize = true;
            lbACTurbo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbACTurbo.Location = new Point(519, 797);
            lbACTurbo.Name = "lbACTurbo";
            lbACTurbo.Size = new Size(150, 32);
            lbACTurbo.TabIndex = 59;
            lbACTurbo.Text = "Enable turbo";
            // 
            // btnACTurbo
            // 
            btnACTurbo.Location = new Point(519, 718);
            btnACTurbo.Name = "btnACTurbo";
            btnACTurbo.Size = new Size(149, 64);
            btnACTurbo.TabIndex = 58;
            btnACTurbo.UseVisualStyleBackColor = true;
            btnACTurbo.Click += btnACTurbo_Click;
            // 
            // lbLampLightFactor
            // 
            lbLampLightFactor.AutoSize = true;
            lbLampLightFactor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbLampLightFactor.Location = new Point(1754, 800);
            lbLampLightFactor.Name = "lbLampLightFactor";
            lbLampLightFactor.Size = new Size(130, 32);
            lbLampLightFactor.TabIndex = 64;
            lbLampLightFactor.Text = "light factor";
            // 
            // btnIsLampOn
            // 
            btnIsLampOn.Location = new Point(1332, 823);
            btnIsLampOn.Name = "btnIsLampOn";
            btnIsLampOn.Size = new Size(149, 64);
            btnIsLampOn.TabIndex = 62;
            btnIsLampOn.UseVisualStyleBackColor = true;
            btnIsLampOn.Click += btnIsLampOn_Click;
            // 
            // lbLampName
            // 
            lbLampName.AutoSize = true;
            lbLampName.BorderStyle = BorderStyle.FixedSingle;
            lbLampName.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbLampName.Location = new Point(1438, 718);
            lbLampName.Name = "lbLampName";
            lbLampName.Size = new Size(288, 72);
            lbLampName.TabIndex = 60;
            lbLampName.Text = "lamp name";
            // 
            // lbLampNameHint
            // 
            lbLampNameHint.AutoSize = true;
            lbLampNameHint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbLampNameHint.Location = new Point(1572, 911);
            lbLampNameHint.Name = "lbLampNameHint";
            lbLampNameHint.Size = new Size(78, 32);
            lbLampNameHint.TabIndex = 66;
            lbLampNameHint.Text = "Name";
            // 
            // lbIsLampOn
            // 
            lbIsLampOn.AutoSize = true;
            lbIsLampOn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbIsLampOn.Location = new Point(1363, 911);
            lbIsLampOn.Name = "lbIsLampOn";
            lbIsLampOn.Size = new Size(65, 32);
            lbIsLampOn.TabIndex = 65;
            lbIsLampOn.Text = "Is on";
            // 
            // tbLampName
            // 
            tbLampName.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbLampName.Location = new Point(1549, 821);
            tbLampName.Name = "tbLampName";
            tbLampName.PlaceholderText = "name";
            tbLampName.Size = new Size(130, 66);
            tbLampName.TabIndex = 67;
            tbLampName.KeyPress += tbLampName_KeyPress;
            // 
            // cbTVVolume
            // 
            cbTVVolume.Enabled = false;
            cbTVVolume.FormattingEnabled = true;
            cbTVVolume.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            cbTVVolume.Location = new Point(1332, 303);
            cbTVVolume.Name = "cbTVVolume";
            cbTVVolume.Size = new Size(182, 33);
            cbTVVolume.TabIndex = 68;
            cbTVVolume.SelectedIndexChanged += cbTVVolume_SelectedIndexChanged;
            // 
            // cbFridgeTemperature
            // 
            cbFridgeTemperature.Enabled = false;
            cbFridgeTemperature.FormattingEnabled = true;
            cbFridgeTemperature.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbFridgeTemperature.Location = new Point(408, 54);
            cbFridgeTemperature.Name = "cbFridgeTemperature";
            cbFridgeTemperature.Size = new Size(182, 33);
            cbFridgeTemperature.TabIndex = 69;
            cbFridgeTemperature.SelectedIndexChanged += cbFridgeTemperature_SelectedIndexChanged;
            // 
            // cbTvLightFactor
            // 
            cbTvLightFactor.Enabled = false;
            cbTvLightFactor.FormattingEnabled = true;
            cbTvLightFactor.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            cbTvLightFactor.Location = new Point(1730, 196);
            cbTvLightFactor.Name = "cbTvLightFactor";
            cbTvLightFactor.Size = new Size(182, 33);
            cbTvLightFactor.TabIndex = 70;
            cbTvLightFactor.SelectedIndexChanged += cbTvLightFactor_SelectedIndexChanged;
            // 
            // cbACTemperature
            // 
            cbACTemperature.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbACTemperature.Enabled = false;
            cbACTemperature.FormattingEnabled = true;
            cbACTemperature.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cbACTemperature.Location = new Point(14, 875);
            cbACTemperature.Name = "cbACTemperature";
            cbACTemperature.Size = new Size(182, 33);
            cbACTemperature.TabIndex = 71;
            cbACTemperature.SelectedIndexChanged += cbACTemperature_SelectedIndexChanged;
            // 
            // lbIsRoom1On
            // 
            lbIsRoom1On.AutoSize = true;
            lbIsRoom1On.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbIsRoom1On.Location = new Point(910, 53);
            lbIsRoom1On.Name = "lbIsRoom1On";
            lbIsRoom1On.Size = new Size(129, 32);
            lbIsRoom1On.TabIndex = 73;
            lbIsRoom1On.Text = "Is room on";
            lbIsRoom1On.Click += label1_Click;
            // 
            // btnIsRoom1On
            // 
            btnIsRoom1On.Location = new Point(899, 93);
            btnIsRoom1On.Name = "btnIsRoom1On";
            btnIsRoom1On.Size = new Size(149, 64);
            btnIsRoom1On.TabIndex = 72;
            btnIsRoom1On.UseVisualStyleBackColor = true;
            btnIsRoom1On.Click += btnIsRoom1On_Click;
            // 
            // lbIsRoom2On
            // 
            lbIsRoom2On.AutoSize = true;
            lbIsRoom2On.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbIsRoom2On.Location = new Point(899, 1009);
            lbIsRoom2On.Name = "lbIsRoom2On";
            lbIsRoom2On.Size = new Size(129, 32);
            lbIsRoom2On.TabIndex = 75;
            lbIsRoom2On.Text = "Is room on";
            // 
            // btnIsRoom2On
            // 
            btnIsRoom2On.Location = new Point(890, 923);
            btnIsRoom2On.Name = "btnIsRoom2On";
            btnIsRoom2On.Size = new Size(149, 64);
            btnIsRoom2On.TabIndex = 74;
            btnIsRoom2On.UseVisualStyleBackColor = true;
            btnIsRoom2On.Click += btnIsRoom2On_Click;
            // 
            // tbR1Name
            // 
            tbR1Name.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbR1Name.Location = new Point(817, 168);
            tbR1Name.Name = "tbR1Name";
            tbR1Name.PlaceholderText = "Enter room name";
            tbR1Name.Size = new Size(332, 66);
            tbR1Name.TabIndex = 76;
            tbR1Name.KeyPress += tbR1Name_KeyPress;
            // 
            // tbRoom2Name
            // 
            tbRoom2Name.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbRoom2Name.Location = new Point(813, 724);
            tbRoom2Name.Name = "tbRoom2Name";
            tbRoom2Name.PlaceholderText = "Enter room name";
            tbRoom2Name.Size = new Size(332, 66);
            tbRoom2Name.TabIndex = 78;
            tbRoom2Name.KeyPress += tbRoom2Name_KeyPress;
            // 
            // tbRoom2Type
            // 
            tbRoom2Type.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbRoom2Type.Location = new Point(788, 795);
            tbRoom2Type.Name = "tbRoom2Type";
            tbRoom2Type.PlaceholderText = "Enter room type";
            tbRoom2Type.Size = new Size(399, 66);
            tbRoom2Type.TabIndex = 77;
            tbRoom2Type.KeyPress += tbRoom2Type_KeyPress;
            // 
            // tbFridgeName
            // 
            tbFridgeName.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFridgeName.Location = new Point(43, 137);
            tbFridgeName.Name = "tbFridgeName";
            tbFridgeName.PlaceholderText = "name";
            tbFridgeName.Size = new Size(130, 66);
            tbFridgeName.TabIndex = 22;
            tbFridgeName.KeyPress += tbFridgeName_KeyPress;
            // 
            // cbLampLightFactor
            // 
            cbLampLightFactor.Enabled = false;
            cbLampLightFactor.FormattingEnabled = true;
            cbLampLightFactor.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbLampLightFactor.Location = new Point(1732, 747);
            cbLampLightFactor.Name = "cbLampLightFactor";
            cbLampLightFactor.Size = new Size(182, 33);
            cbLampLightFactor.TabIndex = 79;
            cbLampLightFactor.SelectedIndexChanged += cbLampLightFactor_SelectedIndexChanged;
            // 
            // HomeAutomationControllerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(cbLampLightFactor);
            Controls.Add(tbRoom2Name);
            Controls.Add(tbRoom2Type);
            Controls.Add(tbR1Name);
            Controls.Add(lbIsRoom2On);
            Controls.Add(btnIsRoom2On);
            Controls.Add(lbIsRoom1On);
            Controls.Add(btnIsRoom1On);
            Controls.Add(cbACTemperature);
            Controls.Add(cbTvLightFactor);
            Controls.Add(cbFridgeTemperature);
            Controls.Add(cbTVVolume);
            Controls.Add(tbLampName);
            Controls.Add(lbLampNameHint);
            Controls.Add(lbIsLampOn);
            Controls.Add(lbLampLightFactor);
            Controls.Add(btnIsLampOn);
            Controls.Add(lbLampName);
            Controls.Add(lbACTurbo);
            Controls.Add(btnACTurbo);
            Controls.Add(tbACLateStop);
            Controls.Add(tbACLateStart);
            Controls.Add(cbACSpeed);
            Controls.Add(cbAcMode);
            Controls.Add(cbACDirection);
            Controls.Add(lbACDirection);
            Controls.Add(lbAcMode);
            Controls.Add(lbACLateStop);
            Controls.Add(lbIsACOn);
            Controls.Add(btnIsACOn);
            Controls.Add(lbACSpeed);
            Controls.Add(lbACSelfCleaning);
            Controls.Add(btnACSelfCleaning);
            Controls.Add(lbACLateStart);
            Controls.Add(lbACTemperature);
            Controls.Add(lbACNameHint);
            Controls.Add(tbACName);
            Controls.Add(lbACName);
            Controls.Add(pR2AC);
            Controls.Add(pR2L);
            Controls.Add(lbFridgeSmartCooling);
            Controls.Add(btnFridgeSmartCooling);
            Controls.Add(lbFridgeEnergyEffect);
            Controls.Add(btnFridgeEnergyEffect);
            Controls.Add(lbFridgeTemperature);
            Controls.Add(lbIsFridgeOn);
            Controls.Add(btnIsFridgeOn);
            Controls.Add(lbFridgeNameHint);
            Controls.Add(tbFridgeName);
            Controls.Add(lbFridgeName);
            Controls.Add(pR1Fridge);
            Controls.Add(lbTvNameHint);
            Controls.Add(lbTvNightMode);
            Controls.Add(lbTvVolume);
            Controls.Add(lbTvLightFactor);
            Controls.Add(lbIsTvOn);
            Controls.Add(btnTvNightMode);
            Controls.Add(btnIsTvOn);
            Controls.Add(pR1TV);
            Controls.Add(lbTvName);
            Controls.Add(tbTvName);
            Controls.Add(tbHomeRoom2);
            Controls.Add(tbHomeRoom1);
            Controls.Add(tbR1Type);
            Controls.Add(lbHome);
            Controls.Add(tbHome);
            Enabled = false;
            Name = "HomeAutomationControllerForm";
            Text = "Form1";
            FormClosed += HomeAutomationControllerForm_FormClosed;
            Load += HomeAutomationControllerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void tbHome_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox tbHome;
        private Label lbHome;
        private TextBox tbR1Type;
        private TextBox tbHomeRoom1;
        private TextBox tbHomeRoom2;
        private Label lbTvName;
        private TextBox tbTvName;
        private Panel pR1TV;
        private Button btnIsTvOn;
        private Button btnTvNightMode;
        private Label lbIsTvOn;
        private Label lbTvLightFactor;
        private Label lbTvVolume;
        private Label lbTvNightMode;
        private Label lbTvNameHint;
        private Panel pR1Fridge;
        private Label lbFridgeName;
        private Label lbFridgeNameHint;
        private Label lbIsFridgeOn;
        private Button btnIsFridgeOn;
        private Label lbFridgeTemperature;
        private Label lbFridgeEnergyEffect;
        private Button btnFridgeEnergyEffect;
        private Label lbFridgeSmartCooling;
        private Button btnFridgeSmartCooling;
        private Panel pR2L;
        private Label lbACSpeed;
        private Label lbACSelfCleaning;
        private Button btnACSelfCleaning;
        private Label lbACLateStart;
        private Label label4;
        private Button button3;
        private Label lbACTemperature;
        private Label lbACNameHint;
        private TextBox tbACName;
        private Label lbACName;
        private Panel pR2AC;
        private Label lbIsACOn;
        private Button btnIsACOn;
        private Label lbACLateStop;
        private Button button6;
        private Label lbAcMode;
        private Label lbACDirection;
        private ComboBox cbACDirection;
        private ComboBox cbAcMode;
        private ComboBox cbACSpeed;
        private TextBox tbACLateStart;
        private TextBox tbACLateStop;
        private Label lbACTurbo;
        private Button btnACTurbo;
        private Label lbLampLightFactor;
        private Button btnIsLampOn;
        private Label lbLampName;
        private Label lbLampNameHint;
        private Label label2;
        private Label lbIsLampOn;
        private TextBox tbLampName;
        private ComboBox cbTVVolume;
        private ComboBox cbFridgeTemperature;
        private ComboBox cbTvLightFactor;
        private ComboBox cbACTemperature;
        private Label lbIsRoom1On;
        private Button btnIsRoom1On;
        private Label lbIsRoom2On;
        private Button btnIsRoom2On;
        private TextBox tbR1Name;
        private TextBox tbRoom2Name;
        private TextBox tbRoom2Type;
        private TextBox tbFridgeName;
        private ComboBox cbLampLightFactor;
    }
}
