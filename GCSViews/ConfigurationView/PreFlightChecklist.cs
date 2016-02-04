﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class PreFlightChecklist : UserControl
    {
        public PreFlightChecklist()
        {
            InitializeComponent();
            BindData();
        }

        public void BindData()
        {


            //if ( MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.E386)
            //{
            //    if (MainV2.comPort.MAV.cs.satcount >= 5 && MainV2.comPort.MAV.cs.gpsstatus >= 3)
            //    {
            //        lblGPS.Image = MissionPlanner.Properties.Resources.Green_panel1;
            //        chBoxGPS.Checked = true;
            //        lblGPS.Text = "3D fix and 5 or more satellites connected";
            //    }
            //    else
            //    {
            //        lblGPS.Image = MissionPlanner.Properties.Resources.Red_panel;
            //        chBoxGPS.Checked = false;
            //        lblGPS.Text = "3D fix or satellites failed or both";
            //    }

            //    if (MainV2.comPort.MAV.cs.linkqualitygcs >= 90)
            //    {
            //        lblTel.Image = MissionPlanner.Properties.Resources.Green_panel1;
            //        lblTel.Text = "signal >= 90%";
            //        chBoxTel.Checked = true;
            //    }
            //    else
            //    {
            //        lblTel.Image = MissionPlanner.Properties.Resources.Red_panel;
            //        lblTel.Text = "signal < 90%";
            //        chBoxTel.Checked = false;
            //    }

            //    if (MainV2.comPort.MAV.cs.battery_voltage >= 15.99)
            //    {
            //        lblBattery.Text = "Voltage > 15.99";
            //        lblBattery.Image = MissionPlanner.Properties.Resources.Green_panel1;
            //        chBoxBattery.Checked = true;
            //    }
            //    else if (MainV2.comPort.MAV.cs.battery_voltage >= 14.5 && MainV2.comPort.MAV.cs.battery_voltage <= 15.98)
            //    {
            //        lblBattery.Text = "Voltage between 14.5 and 15.98";
            //        lblBattery.Image = MissionPlanner.Properties.Resources.Yellow_panel;
            //        chBoxBattery.Checked = true;
            //    }
            //    else
            //    {
            //        lblBattery.Text = "Voltage less than 14.5";
            //        lblBattery.Image = MissionPlanner.Properties.Resources.Red_panel;
            //        chBoxBattery.Checked = false;
            //    }
            //    this.label14.Text = "Valid Waypoints";
            //    this.label3.Text = "All servos respond to tilting the aircraft";
            //    this.label4.Text = "Center of gravity at points indicated ";
            //    this.label2.Text = "All servos respond to R/C stick inputs";
            //    this.label6.Text = "Servo linkages are secure";
            //    this.label12.Text = "Tail and wings are secured to the body";
            //    this.label5.Text = "Camera is on and test shot has been taken";
            //    this.label15.Text = "Verify Compass Heading";
            //}

            //if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Scout)
            //{
            //    if (MainV2.comPort.MAV.cs.satcount >= 5 && MainV2.comPort.MAV.cs.gpsstatus >= 3)
            //    {
            //        lblGPS.Image = MissionPlanner.Properties.Resources.Green_panel1;
            //        chBoxGPS.Checked = true;
            //        lblGPS.Text = "3D fix and 5 or more satellites connected";
            //    }
            //    else
            //    {
            //        lblGPS.Image = MissionPlanner.Properties.Resources.Red_panel;
            //        chBoxGPS.Checked = false;
            //        lblGPS.Text = "3D fix or satellites failed or both";
            //    }

            //    if (MainV2.comPort.MAV.cs.linkqualitygcs >= 90)
            //    {
            //        lblTel.Image = MissionPlanner.Properties.Resources.Green_panel1;
            //        lblTel.Text = "signal >= 90%";
            //        chBoxTel.Checked = true;
            //    }
            //    else
            //    {
            //        lblTel.Image = MissionPlanner.Properties.Resources.Red_panel;
            //        lblTel.Text = "signal < 90%";
            //        chBoxTel.Checked = false;
            //    }

            //    if (MainV2.comPort.MAV.cs.battery_voltage >= 15.99)
            //    {
            //        lblBattery.Text = "Voltage > 15.99";
            //        lblBattery.Image = MissionPlanner.Properties.Resources.Green_panel1;
            //        chBoxBattery.Checked = true;
            //    }
            //    else if (MainV2.comPort.MAV.cs.battery_voltage >= 14.5 && MainV2.comPort.MAV.cs.battery_voltage <= 15.98)
            //    {
            //        lblBattery.Text = "Voltage between 14.5 and 15.98";
            //        lblBattery.Image = MissionPlanner.Properties.Resources.Yellow_panel;
            //        chBoxBattery.Checked = true;
            //    }
            //    else
            //    {
            //        lblBattery.Text = "Voltage less than 14.5";
            //        lblBattery.Image = MissionPlanner.Properties.Resources.Red_panel;
            //        chBoxBattery.Checked = false;
            //    }
            //    this.label14.Text = "Valid Waypoints";
            //    this.label3.Text = "All servos respond to tilting the aircraft";
            //    this.label4.Text = "Center of gravity at points indicated ";
            //    this.label2.Text = "All servos respond to R/C stick inputs";
            //    this.label6.Text = "Servo linkages are secure";
            //    this.label12.Text = "Tail and wings are secured to the body";
            //    this.label5.Text = "Camera is on and test shot has been taken";
            //    this.label15.Text = "Verify Compass Heading";
            //}
            if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane || MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx || MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover || MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduTracker)
            {
                if (MainV2.comPort.MAV.cs.satcount >= 5 && MainV2.comPort.MAV.cs.gpsstatus >= 3)
                {
                    lblGPS.Image = MissionPlanner.Properties.Resources.Green_panel1;
                    chBoxGPS.Checked = true;
                    lblGPS.Text = "3D fix and 5 or more satellites connected";
                }
                else
                {
                    lblGPS.Image = MissionPlanner.Properties.Resources.Red_panel;
                   chBoxGPS.Checked = false;
                    lblGPS.Text = "3D fix or satellites failed or both";
                }

                if (MainV2.comPort.MAV.cs.linkqualitygcs >= 90)
                {
                    lblTel.Image = MissionPlanner.Properties.Resources.Green_panel1;
                    lblTel.Text = "signal >= 90%";
                    chBoxTel.Checked = true;
                }
                else
                {
                    lblTel.Image = MissionPlanner.Properties.Resources.Red_panel;
                    lblTel.Text = "signal < 90%";
                    chBoxTel.Checked = false;
                }

                if (MainV2.comPort.MAV.cs.battery_voltage >= 15.99)
                {
                    lblBattery.Text = "Voltage > 15.99";
                    lblBattery.Image = MissionPlanner.Properties.Resources.Green_panel1;
                   chBoxBattery.Checked = true;
                }
                else if (MainV2.comPort.MAV.cs.battery_voltage >= 14.5 && MainV2.comPort.MAV.cs.battery_voltage <= 15.98)
                {
                    lblBattery.Text = "Voltage between 14.5 and 15.98";
                    lblBattery.Image = MissionPlanner.Properties.Resources.Yellow_panel;
                    chBoxBattery.Checked = true;
                }
              

                else
                {
                    lblBattery.Text = "Voltage less than 14.5";
                   lblBattery.Image = MissionPlanner.Properties.Resources.Red_panel;
                   chBoxBattery.Checked = false;
                }
        

             
                if (MainV2.comPort.MAV.cs.sonarvoltage != 0)
                   {
                    lidarchk.Checked = true;
                    LidarText.Text = "Lidar is enabled";
                    LidarText.Image = MissionPlanner.Properties.Resources.Green_panel;
                   }
              else if (MainV2.comPort.MAV.cs.sonarvoltage == 0)
                   {
                     lidarchk.Checked = false;
                     LidarText.Text = "Check Lidar";
                     LidarText.Image = MissionPlanner.Properties.Resources.Red_panel;
                    }



                if (MainV2.CurrentUAV.firmware == "E386" && lidarchk.Visible == false)
                {
                    lidarchk.Visible = true;
                    LidarClean.Visible = true;
                    LidarCleanCHK.Visible = true;
                    LidarEnabled.Visible = true;
                    LidarText.Visible = true;
                    YNlidar.Visible = true;
                }
         if (MainV2.CurrentUAV.firmware != "E386" && lidarchk.Visible == true) {
             lidarchk.Visible = false;
             LidarClean.Visible = false;
             LidarCleanCHK.Visible = false;
             LidarEnabled.Visible = false;
             LidarText.Visible = false;
             YNlidar.Visible = false;
         }       
                this.label14.Text = "Valid Waypoints";
                this.label3.Text = "All servos respond to tilting the aircraft";
                this.label4.Text = "Center of gravity at points indicated ";
                this.label2.Text = "All servos respond to R/C stick inputs";
                this.label6.Text = "Servo linkages are secure";
                this.label12.Text = "Tail and wings are secured to the body";
                this.label5.Text = "Camera is on and test shot has been taken";
                this.label15.Text = "Verify Compass Heading";            
                        
            }
                //if (MainV2.comPort.MAV.cs.mode.Equals("FBWA", StringComparison.OrdinalIgnoreCase))
                //{
                //    lblRemote.Text = MainV2.comPort.MAV.cs.mode;
                //    lblRemote.Image = MissionPlanner.Properties.Resources.Green_panel1;
                //    chBoxRemote.Checked = true;
                //}
                //else
                //{
                //    lblRemote.Text = MainV2.comPort.MAV.cs.mode;
                //    lblRemote.Image = MissionPlanner.Properties.Resources.Red_panel;
                //    chBoxRemote.Checked = false;
                //}

                //if (MainV2.comPort.MAV.cs.alt <= 10)
                //{
                //    lblAltitude.Text = MainV2.comPort.MAV.cs.alt.ToString();
                //    lblAltitude.Image = MissionPlanner.Properties.Resources.Green_panel1;
                //    chBoxAltitude.Checked = true;
                //}
                //else
                //{
                //    lblAltitude.Text = MainV2.comPort.MAV.cs.alt.ToString();
                //    lblAltitude.Image = MissionPlanner.Properties.Resources.Red_panel;
                //    chBoxAltitude.Checked = false;
                //}
         //   }
            //Need to add one more condition

            if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
            {
                if (MainV2.CurrentUAV.firmware != "E386" && lidarchk.Visible == true)
                {
                    lidarchk.Visible = false;
                    LidarClean.Visible = false;
                    LidarCleanCHK.Visible = false;
                    LidarEnabled.Visible = false;
                    LidarText.Visible = false;
                    YNlidar.Visible = false;
                }   

                this.label3.Text = "Camera is tightened firmly to the mount";
                this.label4.Text = "Ch 7 switch (auto land) is in OFF position";
                this.label2.Text = "Camera is on and test shot has been taken";
                this.label6.Text = "RTL switch is in the OFF position";
                this.label12.Text = "Propellers are tight and secure";
                this.label5.Text = "Transmitter set to loiter";
                this.label15.Text = "IRIS+ is on a level surface";
                this.label14.Text = "Verify Compass Heading";
               
                if (MainV2.comPort.MAV.cs.satcount >= 5 && MainV2.comPort.MAV.cs.gpsstatus >= 3)
                {
                    lblGPS.Image = MissionPlanner.Properties.Resources.Green_panel1;
                    chBoxGPS.Checked = true;
                    lblGPS.Text = "3D fix and 5 or more satelites connected";
                }
                else
                {
                    lblGPS.Image = MissionPlanner.Properties.Resources.Red_panel;
                    chBoxGPS.Checked = false;
                    lblGPS.Text = "3D fix or satellites failed or both";
                }

                if (MainV2.comPort.MAV.cs.linkqualitygcs >= 90)
                {
                    lblTel.Image = MissionPlanner.Properties.Resources.Green_panel1;
                    lblTel.Text = "signal >= 90%";
                    chBoxTel.Checked = true;
                }
                else
                {
                    lblTel.Image = MissionPlanner.Properties.Resources.Red_panel;
                    lblTel.Text = "signal < 90%";
                    chBoxTel.Checked = false;
                }

                if (MainV2.comPort.MAV.cs.battery_voltage >= 12.6)
                {
                    lblBattery.Text = "Voltage > 12.6";
                    lblBattery.Image = MissionPlanner.Properties.Resources.Green_panel1;
                    chBoxBattery.Checked = true;
                }
                else if (MainV2.comPort.MAV.cs.battery_voltage >= 10.5 && MainV2.comPort.MAV.cs.battery_voltage <= 12.6)
                {
                    lblBattery.Text = "Voltage between 10.5 and 12.6";
                    lblBattery.Image = MissionPlanner.Properties.Resources.Yellow_panel;
                    chBoxBattery.Checked = true;
                }
                else
                {
                    lblBattery.Text = "Voltage less than 10.5";
                    lblBattery.Image = MissionPlanner.Properties.Resources.Red_panel;
                    chBoxBattery.Checked = false;
                }
                
            }
            
            BindUserCheckList();
        }

        private void BindUserCheckList()
        {
            //if (chBoxURCIn.Checked)
            //    lblURcStick.BackColor = Color.Green;
            //else
            //    lblURcStick.BackColor = Color.Red;
            SetColorAndTextOnState(lblURcStick, chBoxURCIn);

            //if (chBoxUTilt.Checked)
            //    lblUtilt.BackColor = Color.Green;
            //else
            //    lblUtilt.BackColor = Color.Red;
            SetColorAndTextOnState(lblUtilt, chBoxUTilt);

            //if (chBoxUCent.Checked)
            //    lblUCent.BackColor = Color.Green;
            //else
            //    lblUCent.BackColor = Color.Red;
            SetColorAndTextOnState(lblUCent, chBoxUCent);

            //if (chBoxUCent.Checked)
            //    lblUCent.BackColor = Color.Green;
            //else
            //    lblUCent.BackColor = Color.Red;
            SetColorAndTextOnState(YNlidar, LidarCleanCHK);

            //if (chBoxUCam.Checked)
            //    lblUCam.BackColor = Color.Green;
            //else
            //    lblUCam.BackColor = Color.Red;
            SetColorAndTextOnState(lblUCam, chBoxUCam);

            //if (chBoxUServo.Checked)
            //    lblUServo.BackColor = Color.Green;
            //else
            //    lblUServo.BackColor = Color.Red;
            SetColorAndTextOnState(lblUServo, chBoxUServo);

            //if (chBoxUWing.Checked)
            //    lblUWing.BackColor = Color.Green;
            //else
            //    lblUWing.BackColor = Color.Red;
            SetColorAndTextOnState(lblUWing, chBoxUWing);

            SetColorAndTextOnState(lblWPCheck, CHK_WPCheck);

            SetColorAndTextOnState(lbl_CompassCheck, CHK_CompassCheck);
        }

        private void SetColorAndTextOnState(Label lbl, CheckBox chBox)
        {
            if (chBox.Checked)
            {
                lbl.Image = MissionPlanner.Properties.Resources.Green_panel1;
                lbl.Text = "Yes";
            }
            else
            {
                lbl.Image = MissionPlanner.Properties.Resources.Red_panel;
                lbl.Text = "No";
            }
        }

        private void chBoxURCIn_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void chBoxUTilt_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void chBoxUCent_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void chBoxUCam_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void chBoxUServo_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void chBoxUWing_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void chBoxURub_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void CHK_WPCheck_CheckedChanged(object sender, EventArgs e)
        {
            BindUserCheckList();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
