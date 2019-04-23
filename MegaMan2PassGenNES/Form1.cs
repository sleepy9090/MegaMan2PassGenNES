/**
 *  @file           Form1.cs / FormMegaMan2PassGenNes
 *  @brief          Password Generator for the Nintendo Game MegaMan V.
 *  @copyright      Shawn M. Crawford 2019
 *  @date           04/23/2019
 *
 *  @remark Author  Shawn M. Crawford (sleepy9090)
 *
 *  @note           N/A
 *
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaMan2PassGenNES
{
    public partial class FormMegaMan2PassGenNes : Form
    {
        private readonly Bitmap _blankBitmap = MegaMan2PassGenNES.Properties.Resources.blank;
        private readonly Bitmap _redDotBitmap = MegaMan2PassGenNES.Properties.Resources.reddot;

        public FormMegaMan2PassGenNes()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            PopulateImages();
            PopulateEnergyTankComboBox();
        }

        private void PopulateEnergyTankComboBox()
        {
            for (int i = 0; i <= 4; i++)
            {
                comboBoxEnergyTanks.Items.Add(i);
            }
            comboBoxEnergyTanks.SelectedIndex = 0;
        }

        private void PopulateImages()
        {
            pictureBoxA1.Image = _blankBitmap;
            pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA1.Image.Tag = _blankBitmap.ToString();
            pictureBoxA2.Image = _blankBitmap;
            pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA2.Image.Tag = _blankBitmap.ToString();
            pictureBoxA3.Image = _blankBitmap;
            pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA3.Image.Tag = _blankBitmap.ToString();
            pictureBoxA4.Image = _blankBitmap;
            pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA4.Image.Tag = _blankBitmap.ToString();
            pictureBoxA5.Image = _blankBitmap;
            pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA5.Image.Tag = _blankBitmap.ToString();

            pictureBoxB1.Image = _blankBitmap;
            pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB1.Image.Tag = _blankBitmap.ToString();
            pictureBoxB2.Image = _blankBitmap;
            pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB2.Image.Tag = _blankBitmap.ToString();
            pictureBoxB3.Image = _blankBitmap;
            pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB3.Image.Tag = _blankBitmap.ToString();
            pictureBoxB4.Image = _blankBitmap;
            pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB4.Image.Tag = _blankBitmap.ToString();
            pictureBoxB5.Image = _blankBitmap;
            pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB5.Image.Tag = _blankBitmap.ToString();

            pictureBoxC1.Image = _blankBitmap;
            pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC1.Image.Tag = _blankBitmap.ToString();
            pictureBoxC2.Image = _blankBitmap;
            pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC2.Image.Tag = _blankBitmap.ToString();
            pictureBoxC3.Image = _blankBitmap;
            pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC3.Image.Tag = _blankBitmap.ToString();
            pictureBoxC4.Image = _blankBitmap;
            pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC4.Image.Tag = _blankBitmap.ToString();
            pictureBoxC5.Image = _blankBitmap;
            pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC5.Image.Tag = _blankBitmap.ToString();

            pictureBoxD1.Image = _blankBitmap;
            pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD1.Image.Tag = _blankBitmap.ToString();
            pictureBoxD2.Image = _blankBitmap;
            pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD2.Image.Tag = _blankBitmap.ToString();
            pictureBoxD3.Image = _blankBitmap;
            pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD3.Image.Tag = _blankBitmap.ToString();
            pictureBoxD4.Image = _blankBitmap;
            pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD4.Image.Tag = _blankBitmap.ToString();
            pictureBoxD5.Image = _blankBitmap;
            pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD5.Image.Tag = _blankBitmap.ToString();

            pictureBoxE1.Image = _blankBitmap;
            pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE1.Image.Tag = _blankBitmap.ToString();
            pictureBoxE2.Image = _blankBitmap;
            pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE2.Image.Tag = _blankBitmap.ToString();
            pictureBoxE3.Image = _blankBitmap;
            pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE3.Image.Tag = _blankBitmap.ToString();
            pictureBoxE4.Image = _blankBitmap;
            pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE4.Image.Tag = _blankBitmap.ToString();
            pictureBoxE5.Image = _blankBitmap;
            pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE5.Image.Tag = _blankBitmap.ToString();
        }

        private void ResetImages()
        {
            pictureBoxA1.Image = null;
            pictureBoxA1.Image = _blankBitmap;
            pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA1.Image.Tag = _blankBitmap.ToString();
            pictureBoxA2.Image = null;
            pictureBoxA2.Image = _blankBitmap;
            pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA2.Image.Tag = _blankBitmap.ToString();
            pictureBoxA3.Image = null;
            pictureBoxA3.Image = _blankBitmap;
            pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA3.Image.Tag = _blankBitmap.ToString();
            pictureBoxA4.Image = null;
            pictureBoxA4.Image = _blankBitmap;
            pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA4.Image.Tag = _blankBitmap.ToString();
            pictureBoxA5.Image = null;
            pictureBoxA5.Image = _blankBitmap;
            pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA5.Image.Tag = _blankBitmap.ToString();

            pictureBoxB1.Image = null;
            pictureBoxB1.Image = _blankBitmap;
            pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB1.Image.Tag = _blankBitmap.ToString();
            pictureBoxB2.Image = null;
            pictureBoxB2.Image = _blankBitmap;
            pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB2.Image.Tag = _blankBitmap.ToString();
            pictureBoxB3.Image = null;
            pictureBoxB3.Image = _blankBitmap;
            pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB3.Image.Tag = _blankBitmap.ToString();
            pictureBoxB4.Image = null;
            pictureBoxB4.Image = _blankBitmap;
            pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB4.Image.Tag = _blankBitmap.ToString();
            pictureBoxB5.Image = null;
            pictureBoxB5.Image = _blankBitmap;
            pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB5.Image.Tag = _blankBitmap.ToString();

            pictureBoxC1.Image = null;
            pictureBoxC1.Image = _blankBitmap;
            pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC1.Image.Tag = _blankBitmap.ToString();
            pictureBoxC2.Image = null;
            pictureBoxC2.Image = _blankBitmap;
            pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC2.Image.Tag = _blankBitmap.ToString();
            pictureBoxC3.Image = null;
            pictureBoxC3.Image = _blankBitmap;
            pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC3.Image.Tag = _blankBitmap.ToString();
            pictureBoxC4.Image = null;
            pictureBoxC4.Image = _blankBitmap;
            pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC4.Image.Tag = _blankBitmap.ToString();
            pictureBoxC5.Image = null;
            pictureBoxC5.Image = _blankBitmap;
            pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC5.Image.Tag = _blankBitmap.ToString();

            pictureBoxD1.Image = null;
            pictureBoxD1.Image = _blankBitmap;
            pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD1.Image.Tag = _blankBitmap.ToString();
            pictureBoxD2.Image = null;
            pictureBoxD2.Image = _blankBitmap;
            pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD2.Image.Tag = _blankBitmap.ToString();
            pictureBoxD3.Image = null;
            pictureBoxD3.Image = _blankBitmap;
            pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD3.Image.Tag = _blankBitmap.ToString();
            pictureBoxD4.Image = null;
            pictureBoxD4.Image = _blankBitmap;
            pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD4.Image.Tag = _blankBitmap.ToString();
            pictureBoxD5.Image = null;
            pictureBoxD5.Image = _blankBitmap;
            pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD5.Image.Tag = _blankBitmap.ToString();

            pictureBoxE1.Image = null;
            pictureBoxE1.Image = _blankBitmap;
            pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE1.Image.Tag = _blankBitmap.ToString();
            pictureBoxE2.Image = null;
            pictureBoxE2.Image = _blankBitmap;
            pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE2.Image.Tag = _blankBitmap.ToString();
            pictureBoxE3.Image = null;
            pictureBoxE3.Image = _blankBitmap;
            pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE3.Image.Tag = _blankBitmap.ToString();
            pictureBoxE4.Image = null;
            pictureBoxE4.Image = _blankBitmap;
            pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE4.Image.Tag = _blankBitmap.ToString();
            pictureBoxE5.Image = null;
            pictureBoxE5.Image = _blankBitmap;
            pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE5.Image.Tag = _blankBitmap.ToString();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ResetImages();

            #region Variables

            bool defeatedAirMan = checkBoxAirMan.Checked;
            bool defeatedBubbleMan = checkBoxBubbleMan.Checked;
            bool defeatedCrashMan = checkBoxCrashMan.Checked;
            bool defeatedFlashMan = checkBoxFlashMan.Checked;
            bool defeatedHeatMan = checkBoxHeatMan.Checked;
            bool defeatedMetalMan = checkBoxMetalMan.Checked;
            bool defeatedQuickMan = checkBoxQuickMan.Checked;
            bool defeatedWoodMan = checkBoxWoodMan.Checked;

            int numberOfEnergyTanks = comboBoxEnergyTanks.SelectedIndex;

            #endregion

            switch (numberOfEnergyTanks)
            {
                #region Zero Energy Tanks
                case 0:
                    pictureBoxA1.Image = null;
                    pictureBoxA1.Image = _redDotBitmap;
                    pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA1.Image.Tag = _redDotBitmap.ToString();

                    if (defeatedAirMan)
                    {
                        pictureBoxE3.Image = null;
                        pictureBoxE3.Image = _redDotBitmap;
                        pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD2.Image = null;
                        pictureBoxD2.Image = _redDotBitmap;
                        pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedBubbleMan)
                    {
                        pictureBoxD1.Image = null;
                        pictureBoxD1.Image = _redDotBitmap;
                        pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC3.Image = null;
                        pictureBoxC3.Image = _redDotBitmap;
                        pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedCrashMan)
                    {
                        pictureBoxC5.Image = null;
                        pictureBoxC5.Image = _redDotBitmap;
                        pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE2.Image = null;
                        pictureBoxE2.Image = _redDotBitmap;
                        pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedFlashMan)
                    {
                        pictureBoxC1.Image = null;
                        pictureBoxC1.Image = _redDotBitmap;
                        pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE4.Image = null;
                        pictureBoxE4.Image = _redDotBitmap;
                        pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedHeatMan)
                    {
                        pictureBoxB2.Image = null;
                        pictureBoxB2.Image = _redDotBitmap;
                        pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD5.Image = null;
                        pictureBoxD5.Image = _redDotBitmap;
                        pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedMetalMan)
                    {
                        pictureBoxE5.Image = null;
                        pictureBoxE5.Image = _redDotBitmap;
                        pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE1.Image = null;
                        pictureBoxE1.Image = _redDotBitmap;
                        pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedQuickMan)
                    {
                        pictureBoxB4.Image = null;
                        pictureBoxB4.Image = _redDotBitmap;
                        pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC4.Image = null;
                        pictureBoxC4.Image = _redDotBitmap;
                        pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedWoodMan)
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _redDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxB5.Image = null;
                        pictureBoxB5.Image = _redDotBitmap;
                        pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB5.Image.Tag = _redDotBitmap.ToString();
                    }
                    break;
                #endregion
                #region One Energy Tank
                case 1:
                    pictureBoxA2.Image = null;
                    pictureBoxA2.Image = _redDotBitmap;
                    pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA2.Image.Tag = _redDotBitmap.ToString();

                    if (defeatedAirMan)
                    {
                        pictureBoxE4.Image = null;
                        pictureBoxE4.Image = _redDotBitmap;
                        pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _redDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedBubbleMan)
                    {
                        pictureBoxD2.Image = null;
                        pictureBoxD2.Image = _redDotBitmap;
                        pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC4.Image = null;
                        pictureBoxC4.Image = _redDotBitmap;
                        pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedCrashMan)
                    {
                        pictureBoxD1.Image = null;
                        pictureBoxD1.Image = _redDotBitmap;
                        pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE3.Image = null;
                        pictureBoxE3.Image = _redDotBitmap;
                        pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedFlashMan)
                    {
                        pictureBoxC2.Image = null;
                        pictureBoxC2.Image = _redDotBitmap;
                        pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE5.Image = null;
                        pictureBoxE5.Image = _redDotBitmap;
                        pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedHeatMan)
                    {
                        pictureBoxB3.Image = null;
                        pictureBoxB3.Image = _redDotBitmap;
                        pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE1.Image = null;
                        pictureBoxE1.Image = _redDotBitmap;
                        pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedMetalMan)
                    {
                        pictureBoxB1.Image = null;
                        pictureBoxB1.Image = _redDotBitmap;
                        pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE2.Image = null;
                        pictureBoxE2.Image = _redDotBitmap;
                        pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedQuickMan)
                    {
                        pictureBoxB5.Image = null;
                        pictureBoxB5.Image = _redDotBitmap;
                        pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC5.Image = null;
                        pictureBoxC5.Image = _redDotBitmap;
                        pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedWoodMan)
                    {
                        pictureBoxD4.Image = null;
                        pictureBoxD4.Image = _redDotBitmap;
                        pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC1.Image = null;
                        pictureBoxC1.Image = _redDotBitmap;
                        pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC1.Image.Tag = _redDotBitmap.ToString();
                    }
                    break;
                #endregion
                #region Two Energy Tanks
                case 2:
                    pictureBoxA3.Image = null;
                    pictureBoxA3.Image = _redDotBitmap;
                    pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA3.Image.Tag = _redDotBitmap.ToString();

                    if (defeatedAirMan)
                    {
                        pictureBoxE5.Image = null;
                        pictureBoxE5.Image = _redDotBitmap;
                        pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD4.Image = null;
                        pictureBoxD4.Image = _redDotBitmap;
                        pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedBubbleMan)
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _redDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC5.Image = null;
                        pictureBoxC5.Image = _redDotBitmap;
                        pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedCrashMan)
                    {
                        pictureBoxD2.Image = null;
                        pictureBoxD2.Image = _redDotBitmap;
                        pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE4.Image = null;
                        pictureBoxE4.Image = _redDotBitmap;
                        pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedFlashMan)
                    {
                        pictureBoxC3.Image = null;
                        pictureBoxC3.Image = _redDotBitmap;
                        pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxB1.Image = null;
                        pictureBoxB1.Image = _redDotBitmap;
                        pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedHeatMan)
                    {
                        pictureBoxB4.Image = null;
                        pictureBoxB4.Image = _redDotBitmap;
                        pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE2.Image = null;
                        pictureBoxE2.Image = _redDotBitmap;
                        pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedMetalMan)
                    {
                        pictureBoxB2.Image = null;
                        pictureBoxB2.Image = _redDotBitmap;
                        pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE3.Image = null;
                        pictureBoxE3.Image = _redDotBitmap;
                        pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedQuickMan)
                    {
                        pictureBoxC1.Image = null;
                        pictureBoxC1.Image = _redDotBitmap;
                        pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD1.Image = null;
                        pictureBoxD1.Image = _redDotBitmap;
                        pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedWoodMan)
                    {
                        pictureBoxD5.Image = null;
                        pictureBoxD5.Image = _redDotBitmap;
                        pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC2.Image = null;
                        pictureBoxC2.Image = _redDotBitmap;
                        pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC2.Image.Tag = _redDotBitmap.ToString();
                    }
                    break;
                #endregion
                #region Three Energy Tanks
                case 3:
                    pictureBoxA4.Image = null;
                    pictureBoxA4.Image = _redDotBitmap;
                    pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA4.Image.Tag = _redDotBitmap.ToString();

                    if (defeatedAirMan)
                    {
                        pictureBoxB1.Image = null;
                        pictureBoxB1.Image = _redDotBitmap;
                        pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD5.Image = null;
                        pictureBoxD5.Image = _redDotBitmap;
                        pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedBubbleMan)
                    {
                        pictureBoxD4.Image = null;
                        pictureBoxD4.Image = _redDotBitmap;
                        pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD1.Image = null;
                        pictureBoxD1.Image = _redDotBitmap;
                        pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedCrashMan)
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _redDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE5.Image = null;
                        pictureBoxE5.Image = _redDotBitmap;
                        pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedFlashMan)
                    {
                        pictureBoxC4.Image = null;
                        pictureBoxC4.Image = _redDotBitmap;
                        pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxB2.Image = null;
                        pictureBoxB2.Image = _redDotBitmap;
                        pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedHeatMan)
                    {
                        pictureBoxB5.Image = null;
                        pictureBoxB5.Image = _redDotBitmap;
                        pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE3.Image = null;
                        pictureBoxE3.Image = _redDotBitmap;
                        pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedMetalMan)
                    {
                        pictureBoxB3.Image = null;
                        pictureBoxB3.Image = _redDotBitmap;
                        pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE4.Image = null;
                        pictureBoxE4.Image = _redDotBitmap;
                        pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedQuickMan)
                    {
                        pictureBoxC2.Image = null;
                        pictureBoxC2.Image = _redDotBitmap;
                        pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD2.Image = null;
                        pictureBoxD2.Image = _redDotBitmap;
                        pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedWoodMan)
                    {
                        pictureBoxE1.Image = null;
                        pictureBoxE1.Image = _redDotBitmap;
                        pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC3.Image = null;
                        pictureBoxC3.Image = _redDotBitmap;
                        pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC3.Image.Tag = _redDotBitmap.ToString();
                    }
                    break;
                #endregion
                #region Four Energy Tanks
                case 4:
                    pictureBoxA5.Image = null;
                    pictureBoxA5.Image = _redDotBitmap;
                    pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA5.Image.Tag = _redDotBitmap.ToString();

                    if (defeatedAirMan)
                    {
                        pictureBoxB2.Image = null;
                        pictureBoxB2.Image = _redDotBitmap;
                        pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE1.Image = null;
                        pictureBoxE1.Image = _redDotBitmap;
                        pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedBubbleMan)
                    {
                        pictureBoxD5.Image = null;
                        pictureBoxD5.Image = _redDotBitmap;
                        pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD2.Image = null;
                        pictureBoxD2.Image = _redDotBitmap;
                        pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedCrashMan)
                    {
                        pictureBoxD4.Image = null;
                        pictureBoxD4.Image = _redDotBitmap;
                        pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxB1.Image = null;
                        pictureBoxB1.Image = _redDotBitmap;
                        pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedFlashMan)
                    {
                        pictureBoxC5.Image = null;
                        pictureBoxC5.Image = _redDotBitmap;
                        pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxB3.Image = null;
                        pictureBoxB3.Image = _redDotBitmap;
                        pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedHeatMan)
                    {
                        pictureBoxC1.Image = null;
                        pictureBoxC1.Image = _redDotBitmap;
                        pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE4.Image = null;
                        pictureBoxE4.Image = _redDotBitmap;
                        pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedMetalMan)
                    {
                        pictureBoxB4.Image = null;
                        pictureBoxB4.Image = _redDotBitmap;
                        pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE5.Image = null;
                        pictureBoxE5.Image = _redDotBitmap;
                        pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedQuickMan)
                    {
                        pictureBoxC3.Image = null;
                        pictureBoxC3.Image = _redDotBitmap;
                        pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _redDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedWoodMan)
                    {
                        pictureBoxE2.Image = null;
                        pictureBoxE2.Image = _redDotBitmap;
                        pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC4.Image = null;
                        pictureBoxC4.Image = _redDotBitmap;
                        pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC4.Image.Tag = _redDotBitmap.ToString();
                    }
                    break;
                #endregion
                #region Default - Zero Energy Tanks
                default:
                    pictureBoxA1.Image = null;
                    pictureBoxA1.Image = _redDotBitmap;
                    pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA1.Image.Tag = _redDotBitmap.ToString();

                    if (defeatedAirMan)
                    {
                        pictureBoxE3.Image = null;
                        pictureBoxE3.Image = _redDotBitmap;
                        pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD2.Image = null;
                        pictureBoxD2.Image = _redDotBitmap;
                        pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedBubbleMan)
                    {
                        pictureBoxD1.Image = null;
                        pictureBoxD1.Image = _redDotBitmap;
                        pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC3.Image = null;
                        pictureBoxC3.Image = _redDotBitmap;
                        pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedCrashMan)
                    {
                        pictureBoxC5.Image = null;
                        pictureBoxC5.Image = _redDotBitmap;
                        pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE2.Image = null;
                        pictureBoxE2.Image = _redDotBitmap;
                        pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE2.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedFlashMan)
                    {
                        pictureBoxC1.Image = null;
                        pictureBoxC1.Image = _redDotBitmap;
                        pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE4.Image = null;
                        pictureBoxE4.Image = _redDotBitmap;
                        pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedHeatMan)
                    {
                        pictureBoxB2.Image = null;
                        pictureBoxB2.Image = _redDotBitmap;
                        pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxD5.Image = null;
                        pictureBoxD5.Image = _redDotBitmap;
                        pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedMetalMan)
                    {
                        pictureBoxE5.Image = null;
                        pictureBoxE5.Image = _redDotBitmap;
                        pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxE1.Image = null;
                        pictureBoxE1.Image = _redDotBitmap;
                        pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxE1.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedQuickMan)
                    {
                        pictureBoxB4.Image = null;
                        pictureBoxB4.Image = _redDotBitmap;
                        pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxC4.Image = null;
                        pictureBoxC4.Image = _redDotBitmap;
                        pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC4.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedWoodMan)
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _redDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else
                    {
                        pictureBoxB5.Image = null;
                        pictureBoxB5.Image = _redDotBitmap;
                        pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB5.Image.Tag = _redDotBitmap.ToString();
                    }
                    break;
                #endregion
            }
        }
    }
}
