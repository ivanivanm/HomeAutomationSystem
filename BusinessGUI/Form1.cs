using DataAccessLayer;
using DataAccessLayer.BuilderModels;
using DataAccessLayer.CRUD;
using DataAccessLayer.MainModel;
using DataAccessLayer.Models;

namespace BusinessGUI
{
    public partial class HomeAutomationControllerForm : Form
    {
        //controls info objects
        private HomeAutomationDbContext _context;
        private RoomContext rc;
        private TVContext tvc;
        private LampContext lc;
        private FridgeContext fc;
        private AirConditionerContext acc;
        private Home home;
        private Room r1;
        private Room r2;
        private TV tv;
        private Lamp l;
        private Fridge f;
        private AirConditioner ac;

        //controls collections
        private List<Control> tvControls;
        private List<Control> acControls;
        private List<Control> fridgeControls;
        private List<Control> lampControls;

        private List<Control> r1Controls;
        private List<Control> r2Controls;

        private List<Control> homeControls;
        public HomeAutomationControllerForm()
        {
            InitializeComponent();
            this.Enabled = true;

            AdjustInitialVisibility();
            MakeSureDataExists();
            LoadControlsWithInfo();
            GroupControls();
        }
        private void HomeAutomationControllerForm_Load(object sender, EventArgs e)
        {
            this.Enabled = true;

            AdjustInitialVisibility();
            MakeSureDataExists();
            LoadControlsWithInfo();
            GroupControls();
        }
        private void GroupControls()
        {
            tvControls = new List<Control>()
            {
                tbTvName, lbTvNameHint,
                btnTvNightMode, lbTvNightMode,
                cbTvLightFactor, lbTvLightFactor,
                cbTVVolume, lbTvVolume
            };
            acControls = new List<Control>()
            {
                tbACName,lbACNameHint,
                btnACSelfCleaning,lbACSelfCleaning,
                tbACLateStart,lbACLateStart,
                tbACLateStop,lbACLateStop,
                cbACTemperature,lbACTemperature,
                cbACSpeed,lbACSpeed,
                cbACDirection,lbACDirection,
                cbAcMode,lbAcMode
            };
            fridgeControls = new List<Control>()
            {
                tbFridgeName,lbFridgeNameHint,
                btnFridgeEnergyEffect,lbFridgeEnergyEffect,
                btnFridgeSmartCooling,lbFridgeSmartCooling,
                cbFridgeTemperature,lbFridgeTemperature
            };
            lampControls = new List<Control>()
            {
                tbLampName,lbLampNameHint,
                cbLampLightFactor,lbLampLightFactor
            };

            r1Controls = new List<Control>()
            {
                pR1Fridge,pR1TV,
                lbFridgeName,
                btnIsFridgeOn,lbIsFridgeOn,
                lbTvName,
                btnIsTvOn,lbIsTvOn
            };
            r2Controls = new List<Control>()
            {
                pR2AC,pR2L,
                lbACName,
                btnIsACOn,lbIsACOn,
                lbLampName,
                btnIsLampOn,btnIsLampOn
            };
            homeControls = new List<Control>()
            {
                lbHome,tbHome,
                tbHomeRoom1,
                tbHomeRoom2,
                tbR1Name,tbR1Type,
                btnIsRoom1On,lbIsRoom1On,
                tbRoom2Name,tbRoom2Type,
                btnIsRoom1On,lbIsRoom1On
            };
        }
        private void AdjustVisibility(List<Control> controls, bool isVisible)
        {
            foreach (Control control in controls)
            {
                control.Visible = isVisible;
            }
        }
        private void AdjustInitialVisibility()
        {
            foreach (Control control in homeControls)
            {
                control.Visible = true;
            }
            foreach (Control control in r1Controls)
            {
                control.Visible = false;
            }
            foreach (Control control in r2Controls)
            {
                control.Visible = false;
            }
            foreach (Control control in acControls)
            {
                control.Visible = false;
            }
            foreach (Control control in lampControls)
            {
                control.Visible = false;
            }
            foreach (Control control in tvControls)
            {
                control.Visible = false;
            }
            foreach (Control control in fridgeControls)
            {
                control.Visible = false;
            }
        }

        private void LoadControlsWithInfo()
        {
            lbHome.Text = home.Name;

            tbR1Name.Text = r1.Name;
            tbRoom2Name.Text = r2.Name;
            tbR1Type.Text = r1.Type;
            tbRoom2Type.Text = r2.Type;
            btnIsRoom1On.Text = Convert.ToString(r1.On);
            btnIsRoom2On.Text = Convert.ToString(r2.On);

            lbFridgeName.Text = f.Name;
            btnIsFridgeOn.Text = Convert.ToString(f.IsOn);
            cbFridgeTemperature.Text = Convert.ToString(f.Temperature);
            btnFridgeEnergyEffect.Text = Convert.ToString(f.EnergyEffectiveness);
            btnFridgeSmartCooling.Text = Convert.ToString(f.SmartCooling);

            lbTvName.Text = Convert.ToString(tv.Name);
            btnIsTvOn.Text = Convert.ToString(tv.IsOn);
            btnTvNightMode.Text = Convert.ToString(tv.NightMode);
            cbTVVolume.Text = Convert.ToString(tv.Volume);
            cbTvLightFactor.Text = Convert.ToString(tv.LightnessFactor);

            lbLampName.Text = l.Name;
            btnIsLampOn.Text = Convert.ToString(l.IsOn);
            cbLampLightFactor.Text = Convert.ToString(l.LightnessFactor);

            lbACName.Text = ac.Name;
            btnIsACOn.Text = Convert.ToString(ac.IsOn);
            btnACSelfCleaning.Text = Convert.ToString(ac.SelfCleaning);
            tbACLateStart.Text = Convert.ToString(ac.LateStart);
            tbACLateStop.Text = Convert.ToString(ac.LateStop);
            btnACTurbo.Text = Convert.ToString(ac.Turbo);
            cbACTemperature.Text = Convert.ToString(ac.Temperature);
            cbACSpeed.Text = Convert.ToString(ac.AirSpeed);
            cbACDirection.Text = Convert.ToString(ac.AirDir);
            cbAcMode.Text = Convert.ToString(ac.ACMode);

        }
        private void MakeSureDataExists()
        {
            home = _context.Home.ToList()[0];
            if (home is null)
            {
                _context.Home.Add(new Home("home 1"));
                home = _context.Home.ToList()[0];
            }
            r1 = rc.GetAll(true, false).ToList()[0];
            if (r1 is null)
            {
                rc.Add(new Room(false, home.ID, "unknown", "room1"));
                r1 = rc.GetAll(true, false).ToList()[0];
            }
            r2 = rc.GetAll(true, false).ToList()[1];
            if (r2 is null)
            {
                rc.Add(new Room(false, home.ID, "unknown", "room2"));
                r2 = rc.GetAll(true, false).ToList()[1];
            }

            tv = tvc.GetAll(true, false).ToList()[0];
            if (tv is null)
            {
                tvc.Add(new TV(r1.Id, false, "tv1"));
                tv = tvc.GetAll(true, false).ToList()[0];
            }
            f = fc.GetAll(true, false).ToList()[0];
            if (f is null)
            {
                fc.Add(new Fridge(r1.Id, "fridge1", false));
                f = fc.GetAll(true, false).ToList()[0];
            }
            ac = acc.GetAll(true, false).ToList()[0];
            if (ac is null)
            {
                acc.Add(new AirConditioner(false, "ac1", r2.Id));
                ac = acc.GetAll(true, false).ToList()[0];
            }
            l = lc.GetAll(true, false).ToList()[0];
            if (l is null)
            {
                lc.Add(new Lamp(false, r2.Id, "l1"));
                l = lc.GetAll(true, false).ToList()[0];
            }
        }
        private void btnIsRoom1On_Click(object sender, EventArgs e)
        {
            if (r1.On == false)
            {
                r1.On = true;
                rc.Update(r1, false);
                btnIsRoom1On.Text = Convert.ToString(r1.On);

                AdjustVisibility(r1Controls, true);
            }
            else
            {
                f.IsOn = false;
                fc.Update(f, false);
                btnIsFridgeOn.Text = Convert.ToString(f.IsOn);
                AdjustVisibility(fridgeControls, false);

                tv.IsOn = false;
                tvc.Update(tv, false);
                btnIsTvOn.Text = Convert.ToString(tv.IsOn);
                AdjustVisibility(tvControls, false);

                r1.On = false;
                rc.Update(r1, false);
                btnIsRoom1On.Text = Convert.ToString(r1.On);
                AdjustVisibility(r1Controls, false);
            }
        }
        private void btnIsFridgeOn_Click(object sender, EventArgs e)
        {
            if (f.IsOn == false)
            {
                f.IsOn = true;
                fc.Update(f, false);
                btnIsFridgeOn.Text = Convert.ToString(f.IsOn);
                AdjustVisibility(fridgeControls, true);
            }
            else
            {
                f.IsOn = false;
                fc.Update(f, false);
                btnIsFridgeOn.Text = Convert.ToString(f.IsOn);
                AdjustVisibility(fridgeControls, false);
            }
        }
        private void btnIsTvOn_Click_1(object sender, EventArgs e)
        {
            if (tv.IsOn == false)
            {
                tv.IsOn = true;
                tvc.Update(tv, false);
                btnIsTvOn.Text = Convert.ToString(tv.IsOn);
                AdjustVisibility(tvControls, true);
            }
            else
            {
                tv.IsOn = false;
                tvc.Update(tv, false);
                btnIsTvOn.Text = Convert.ToString(tv.IsOn);
                AdjustVisibility(tvControls, false);
            }
        }
        private void btnIsRoom2On_Click(object sender, EventArgs e)
        {
            if (r2.On == false)
            {
                r2.On = true;
                rc.Update(r2, false);
                btnIsRoom2On.Text = Convert.ToString(r2.On);

                AdjustVisibility(r2Controls, true);
            }
            else
            {
                ac.IsOn = false;
                acc.Update(ac, false);
                btnIsACOn.Text = Convert.ToString(ac.IsOn);
                AdjustVisibility(acControls, false);

                l.IsOn = false;
                lc.Update(l, false);
                btnIsLampOn.Text = Convert.ToString(l.IsOn);
                AdjustVisibility(lampControls, false);

                r2.On = false;
                rc.Update(r2, false);
                btnIsRoom2On.Text = Convert.ToString(r2.On);
                AdjustVisibility(r2Controls, false);
            }
        }
        private void btnIsACOn_Click(object sender, EventArgs e)
        {
            if (ac.IsOn == false)
            {
                ac.IsOn = true;
                acc.Update(ac, false);
                btnIsACOn.Text = Convert.ToString(ac.IsOn);
                AdjustVisibility(acControls, true);
            }
            else
            {
                ac.IsOn = false;
                acc.Update(ac, false);
                btnIsACOn.Text = Convert.ToString(ac.IsOn);
                AdjustVisibility(acControls, false);
            }
        }
        private void btnIsLampOn_Click(object sender, EventArgs e)
        {
            if (l.IsOn == false)
            {
                l.IsOn = true;
                lc.Update(l, false);
                btnIsLampOn.Text = Convert.ToString(l.IsOn);
                AdjustVisibility(lampControls, true);
            }
            else
            {
                l.IsOn = false;
                lc.Update(l, false);
                btnIsLampOn.Text = Convert.ToString(l.IsOn);
                AdjustVisibility(lampControls, false);
            }
        }
        private void tbHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newName = tbHome.Text;

                tbHome.Text = "";

                home.Name = newName;
                _context.SaveChanges();

                lbHome.Text = home.Name;
            }
        }
        private void tbR1Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newType = tbR1Type.Text;

                r1.Type = newType;

                rc.Update(r1, false);

                tbR1Type.Text = r1.Type;
            }
        }
        private void tbR1Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newName = tbR1Name.Text;

                r1.Name = newName;

                rc.Update(r1, false);

                tbR1Name.Text = r1.Name;
            }
        }
        private void tbFridgeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newName = tbFridgeName.Text;

                f.Name = newName;

                fc.Update(f, false);

                tbFridgeName.Text = f.Name;
                lbFridgeName.Text = f.Name;
            }
        }
        private void cbFridgeTemperature_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temperature = int.Parse(cbFridgeTemperature.SelectedItem.ToString());
            f.Temperature = temperature;
            fc.Update(f, false);
            cbFridgeTemperature.Text = Convert.ToString(f.Temperature);
        }
        private void btnFridgeEnergyEffect_Click(object sender, EventArgs e)
        {
            if (f.EnergyEffectiveness == false)
            {
                f.EnergyEffectiveness = true;
            }
            else
            {
                f.EnergyEffectiveness = false;
            }
            fc.Update(f, false);
            btnFridgeEnergyEffect.Text = Convert.ToString(f.EnergyEffectiveness);
        }
        private void btnFridgeSmartCooling_Click(object sender, EventArgs e)
        {
            if (f.SmartCooling == false)
            {
                f.SmartCooling = true;
            }
            else
            {
                f.SmartCooling = false;
            }
            fc.Update(f, false);
            btnFridgeSmartCooling.Text = Convert.ToString(f.SmartCooling);
        }
        private void tbTvName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newName = tbTvName.Text;

                tv.Name = newName;

                tvc.Update(tv, false);

                tbTvName.Text = tv.Name;
                lbTvName.Text = tv.Name;
            }
        }
        private void cbTvLightFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lightFactor = int.Parse(cbTvLightFactor.SelectedItem.ToString());
            tv.LightnessFactor = lightFactor;
            tvc.Update(tv, false);
            cbTvLightFactor.Text = Convert.ToString(tv.LightnessFactor);
        }
        private void cbTVVolume_SelectedIndexChanged(object sender, EventArgs e)
        {
            int volume = int.Parse(cbTVVolume.SelectedItem.ToString());
            tv.Volume = volume;
            tvc.Update(tv, false);
            cbTVVolume.Text = Convert.ToString(tv.Volume);
        }
        private void btnTvNightMode_Click(object sender, EventArgs e)
        {
            if (tv.NightMode == false)
            {
                tv.NightMode = true;
            }
            else
            {
                tv.NightMode = false;
            }
            tvc.Update(tv, false);
            btnTvNightMode.Text = Convert.ToString(tv.NightMode);
        }
        private void tbRoom2Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newName = tbRoom2Name.Text;

                r2.Name = newName;

                rc.Update(r2, false);

                tbRoom2Name.Text = r1.Name;
            }
        }
        private void tbRoom2Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newType = tbRoom2Type.Text;

                r2.Type = newType;

                rc.Update(r2, false);

                tbRoom2Type.Text = r2.Type;
            }
        }
        private void tbACName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newName = tbACName.Text;

                ac.Name = newName;

                acc.Update(ac, false);

                tbACName.Text = ac.Name;
                lbACName.Text = ac.Name;
            }
        }
        private void btnACSelfCleaning_Click(object sender, EventArgs e)
        {
            if (ac.SelfCleaning == false)
            {
                ac.SelfCleaning = true;
            }
            else
            {
                ac.SelfCleaning = false;
            }
            acc.Update(ac, false);
            btnACSelfCleaning.Text = Convert.ToString(ac.SelfCleaning);
        }
        private void tbACLateStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int lateStart = int.Parse(tbACLateStart.Text);

                ac.LateStart = lateStart;

                acc.Update(ac, false);

                tbACLateStart.Text = Convert.ToString(ac.LateStart);
            }
        }
        private void tbACLateStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int lateStop = int.Parse(tbACLateStop.Text);

                ac.LateStop = lateStop;

                acc.Update(ac, false);

                tbACLateStop.Text = Convert.ToString(ac.LateStop);
            }
        }
        private void btnACTurbo_Click(object sender, EventArgs e)
        {
            if (ac.Turbo == false)
            {
                ac.Turbo = true;
            }
            else
            {
                ac.Turbo = false;
            }
            acc.Update(ac, false);
            btnACTurbo.Text = Convert.ToString(ac.Turbo);
        }
        private void cbACTemperature_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temperature = int.Parse(cbACTemperature.SelectedItem.ToString());
            ac.Temperature = temperature;
            acc.Update(ac, false);
            cbACTemperature.Text = Convert.ToString(ac.Temperature);
        }
        private void cbACSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            int speed = int.Parse(cbACSpeed.SelectedItem.ToString());
            ac.AirSpeed = speed;
            acc.Update(ac, false);
            cbACSpeed.Text = Convert.ToString(ac.AirSpeed);
        }
        private void cbAcMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = int.Parse(cbAcMode.SelectedItem.ToString());
            ac.ACMode = mode;
            acc.Update(ac, false);
            cbAcMode.Text = Convert.ToString(ac.ACMode);
        }
        private void cbACDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir = cbACDirection.SelectedItem.ToString();
            switch (dir.ToUpper())
            {
                case "UP":
                    ac.AirDir = AirConditioner.Direction.Up;
                    break;
                case "DOWN":
                    ac.AirDir = AirConditioner.Direction.Down;
                    break;
                case "RIGHT":
                    ac.AirDir = AirConditioner.Direction.Right;
                    break;
                case "LEFT":
                    ac.AirDir = AirConditioner.Direction.Left;
                    break;
                default:
                    ac.AirDir = AirConditioner.Direction.Up;
                    break;
            }
            acc.Update(ac, false);
            cbACDirection.Text = Convert.ToString(ac.AirDir);
        }
        private void tbLampName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string newName = tbLampName.Text;

                l.Name = newName;

                lc.Update(l, false);

                tbLampName.Text = l.Name;
                lbLampName.Text = l.Name;
            }
        }
        private void cbLampLightFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lightFactor = int.Parse(cbLampLightFactor.SelectedItem.ToString());
            l.LightnessFactor = lightFactor;
            lc.Update(l, false);
            cbLampLightFactor.Text = Convert.ToString(l.LightnessFactor);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //greshka
        }

        private void tbTvName_TextChanged(object sender, EventArgs e)
        {
            //greshka
        }

        private void lbLightF_Click(object sender, EventArgs e)
        {
            //greshka
        }


        private void label3_Click(object sender, EventArgs e)
        {
            //greshka.....
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //oshte greeshki....
        }

        private void lbACSpeed_Click(object sender, EventArgs e)
        {
            // fomrsa ne obicha useri s laptop
        }

        private void btnIsTvOn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbFridgeTemperature_SelectedIndexChanged0(object sender, EventArgs e)
        {

        }

        private void btnFridgeEnergyEffect_KeyPress(object sender, KeyPressEventArgs e)
        {
            //gresha
        }

      
    }
}
