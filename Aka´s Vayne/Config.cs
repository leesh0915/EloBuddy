﻿using System;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

// ReSharper disable InconsistentNaming
// ReSharper disable MemberHidesStaticFromOuterClass

namespace AddonTemplate
{
    // I can't really help you with my layout of a good config class
    // since everyone does it the way they like it most, go checkout my
    // config classes I make on my GitHub if you wanna take over the
    // complex way that I use
    public static class Config
    {
        private const string MenuName = "Aka´s Vayne";

        private static readonly Menu Menu;

        public static string[] DangerSliderValues = { "Low", "Medium", "High" };

        static Config()
        {

            // Initialize the menu
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("Welcome to my Vayne Addon have fun! :)");
            Menu.AddLabel("To see/change the Settings");
            Menu.AddLabel("Click on Modes :)");

            // Initialize the modes
            Modes.Initialize();
        }

        public static void Initialize()
        {
        }


        public static class Modes
        {
            private static readonly Menu Menu;

            static Modes()
            {
                // Initialize the menu
                Menu = Config.Menu.AddSubMenu("Modes");

                // Initialize all modes
                // Combo
                Combo.Initialize();
                Menu.AddSeparator();
                Condemn.Initialize();
                Menu.AddSeparator();
                // Harass
                Harass.Initialize();
                Menu.AddSeparator();
                Flee.Initialize();
                Menu.AddSeparator();
                LaneClear.Initialize();
                Menu.AddSeparator();
                JungleClear.Initialize();
                Menu.AddSeparator();
                MiscMenu.Initialize();
                Menu.AddSeparator();
                Drawing.Initialize();
                Menu.AddSeparator();

            }

            public static void Initialize()
            {
            }

            public static class Combo
            {
                private static readonly CheckBox _useQs;
                private static readonly CheckBox _useQa;
                private static readonly CheckBox _useQp;
                private static readonly CheckBox _kite;
                private static readonly CheckBox _useE;
                private static readonly CheckBox _Ekill;
                private static readonly CheckBox _useR;
                private static readonly CheckBox _Rnoaa;
                private static readonly Slider _Rnoaas;
                private static readonly Slider _useRSlider;
                private static readonly Slider _Qlogicslider;


                public static bool UseQs
                {
                    get { return _useQs.CurrentValue; }
                }
                public static bool UseQa
                {
                    get { return _useQa.CurrentValue; }
                }
                public static bool UseQp
                {
                    get { return _useQp.CurrentValue; }
                }


                public static bool Kite
                {
                    get { return _kite.CurrentValue; }
                }

                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }
                public static bool Ekill
                {
                    get { return _Ekill.CurrentValue; }
                }

                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }

                public static bool RnoAA
                {
                    get { return _Rnoaa.CurrentValue; }
                }

                public static int RnoAAs
                {
                    get { return _Rnoaas.CurrentValue; }
                }

                public static int UseRSlider
                {
                    get { return _useRSlider.CurrentValue; }
                }

                public static int QLogicSlider
                {
                    get { return _Qlogicslider.CurrentValue; }
                }
                static Combo()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("Combo");
                    _useQs = Menu.Add("comboUseQs", new CheckBox("Use Q(smart)", false));
                    _useQa = Menu.Add("comboUseQa", new CheckBox("Use Q(aka)", false));
                    _useQp = Menu.Add("comboUseQp", new CheckBox("Use Q(Prada) => Use this it´s challengerino!"));
                    _kite = Menu.Add("comboUseQKite", new CheckBox("Use Q Kite Melee´s?"));
                    _Ekill = Menu.Add("Ekill", new CheckBox("Use E if killable?"));
                    _useE = Menu.Add("comboUseE", new CheckBox("Use E"));
                    _useR = Menu.Add("comboUseR", new CheckBox("Use R", false));
                    _Rnoaa = Menu.Add("RnoAA", new CheckBox("No AA while stealth", false));
                    _Rnoaas = Menu.Add("RnoAAs", new Slider("No AA stealth when >= enemy in range", 2, 0, 5));
                    _useRSlider = Menu.Add("comboRSlider", new Slider("Use R if", 2, 1, 5));
                    _Qlogicslider = Menu.Add("QLogicSlider", new Slider("Hold distance from enemy:", 370, 100, 500));
                }

                public static void Initialize()
                {
                }
            }

            public static class Harass
            {

                private static readonly CheckBox _UseQ;
                private static readonly CheckBox _useE;
                private static readonly Slider _Mana;

                public static bool UseQ
                {
                    get { return _UseQ.CurrentValue; }
                }

                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }

                public static int Mana
                {
                    get { return _Mana.CurrentValue; }
                }

                static Harass()
                {
                    // Here is another option on how to use the menu, but I prefer the
                    // way that I used in the combo class
                    Menu.AddGroupLabel("Harass");
                    Menu.AddLabel("I would prefer to tick only 1 of the Options, I prefer the Q one.");
                   _UseQ = Menu.Add("UseQHarrass", new CheckBox("Use Q(if 2 W stacks"));
                    _useE = Menu.Add("UseEHarass", new CheckBox("Use E(if 2 W stacks", false));
                    // Adding a slider, we have a little more options with them, using {0} {1} and {2}
                    // in the display name will replace it with 0=current 1=min and 2=max value
                    _Mana = Menu.Add("ManaHarass", new Slider("Maximum mana usage in percent ({0}%)", 40));
                }

                public static void Initialize()
                {
                }
            }

            public static class Flee
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useE;


                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }

                static Flee()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("Flee");
                    _useQ= Menu.Add("FleeUseQ", new CheckBox("Use Q"));
                    _useE = Menu.Add("FleeUseE", new CheckBox("Use E"));
                }

                public static void Initialize()
                {
                }
            }

            public static class JungleClear
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useE;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }

                static JungleClear()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("JungleClear");
                    _useQ = Menu.Add("JCQ", new CheckBox("Use Q"));
                    _useE = Menu.Add("JCE", new CheckBox("Use E"));
                }

                public static void Initialize()
                {
                }
            }


            public static class LaneClear
            {
                private static readonly CheckBox _useQ;
                private static readonly Slider _useQSlider;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static int UseQSlider
                {
                    get { return _useQSlider.CurrentValue; }
                }
                static LaneClear()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("LaneClear");
                    _useQ = Menu.Add("LCQ", new CheckBox("Use Q"));
                    _useQSlider = Menu.Add("LCQMana", new Slider("Maximum mana usage in percent ({0}%)", 40));
                }

                public static void Initialize()
                {
                }
            }

            public class MiscMenu
            {
                private static readonly CheckBox _AntiRengar;
                private static readonly CheckBox _AntiKalista;
                private static readonly CheckBox _InterruptE;
                private static readonly CheckBox _Gapclose;
                private static readonly Slider _Dangerlvl;
                private static readonly Slider _skinId;
                private static readonly CheckBox _autoBuy;

                public static bool AntiRengar
                {
                    get { return _AntiRengar.CurrentValue; }
                }
                public static bool AntiKalista
                {
                    get { return _AntiKalista.CurrentValue; }
                }
                public static bool InterruptE
                {
                    get { return _InterruptE.CurrentValue; }
                }
                public static bool Gapclose
                {
                    get { return _Gapclose.CurrentValue; }
                }
                public static int Dangerlvl
                {
                    get { return _Dangerlvl.CurrentValue; }
                }

                public static int skinId
                {
                    get { return _skinId.CurrentValue; }
                }

                public static bool autoBuy
                {
                    get { return _autoBuy.CurrentValue; }
                }


                static MiscMenu()
                {

                    Menu.AddGroupLabel("Misc");
                    Menu.AddLabel("Credits to Fluxy:");
                    _Gapclose = Menu.Add("GapcloseE", new CheckBox("Gapclose E"));
                    _AntiRengar = Menu.Add("AntiRengar", new CheckBox("Anti Rengar"));
                    _AntiKalista = Menu.Add("AntiKalista", new CheckBox("Anti Kalista"));
                    _InterruptE = Menu.Add("InterruptE", new CheckBox("Interrupt Spells using E?"));
                    _autoBuy = Menu.Add("autoBuyStartingItems", new CheckBox("Autobuy Starters"));
                    _skinId = Menu.Add("skinId", new Slider("Skin Hack", 7, 1, 9));
                    var dangerSlider = _Dangerlvl = Menu.Add("dangerLevel", new Slider("Set Your Danger Level: ", 3, 1, 3));
                    var dangerSliderDisplay = Menu.Add("dangerLevelDisplay",
                        new Label("Danger Level: " + DangerSliderValues[dangerSlider.Cast<Slider>().CurrentValue - 1]));
                    dangerSlider.Cast<Slider>().OnValueChange += delegate
                    {
                        dangerSliderDisplay.Cast<Label>().DisplayName =
                            "Danger Level: " + DangerSliderValues[dangerSlider.Cast<Slider>().CurrentValue - 1];
                    };
                }

                public static void Initialize()
                {
                }
            }

            public class Condemn
            {
                private static readonly CheckBox _condemn1;
                private static readonly CheckBox _condemn2;
                private static readonly CheckBox _condemn3;
                private static readonly KeyBind _flashe;
                private static readonly CheckBox _trinket;
                private static readonly Slider _condemndistance;

                public static bool Condemn1
                {
                    get { return _condemn1.CurrentValue; }
                }


                public static bool Condemn2
                {
                    get { return _condemn2.CurrentValue; }
                }

                public static bool Condemn3
                {
                    get { return _condemn3.CurrentValue; }
                }

                public static bool FlashE
                {
                    get { return _flashe.CurrentValue; }
                }

                public static bool trinket
                {
                    get { return _trinket.CurrentValue; }
                }
                public static int Condemndistance
                {
                    get { return _condemndistance.CurrentValue; }
                }
                static Condemn()
                {

                    Menu.AddGroupLabel("Condemn");
                    Menu.AddLabel("Only Activate 1 at the same time!, Fluxy is 360° condemn => the best, the others are less obvious");
                    _condemn1 = Menu.Add("condemnmethod1", new CheckBox("Condemn 1(Hiki)", false));
                    _condemn2 = Menu.Add("condemnmethod2", new CheckBox("Condemn 2(VHR)", false));
                    _condemn3 = Menu.Add("condemnmethod3", new CheckBox("Condemn 3(Fluxy)"));
                    _flashe = Menu.Add("flashe", new KeyBind("Flash E!", false, KeyBind.BindTypes.HoldActive, 'Y'));
                    _trinket = Menu.Add("trinket", new CheckBox("Use trinket bush?"));
                    _condemndistance = Menu.Add("pushDistance", new Slider("Condemn Push Distance", 410, 350, 420));
                }

                public static void Initialize()
                {
                }
            }

            public static class Drawing
                {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useE;
                    private static readonly CheckBox _DrawonlyReady;
        
                    public static bool UseE
                    {
                        get { return _useE.CurrentValue; }
                    }

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }

                public static bool DrawOnlyReady
                {
                    get { return _DrawonlyReady.CurrentValue; }
                }

                static Drawing()
                    {
                        // Initialize the menu values
                        Menu.AddGroupLabel("Drawings?");
                    _useQ = Menu.Add("DrawQ", new CheckBox("Draw Q"));
                    _useE = Menu.Add("DrawE", new CheckBox("Draw E"));
                        _DrawonlyReady = Menu.Add("DrawOnlyReady", new CheckBox("Draw Only if Spells are ready"));
                }

                    public static void Initialize()
                    {
                    }
                }

            }
        }
    }

            
        
    

