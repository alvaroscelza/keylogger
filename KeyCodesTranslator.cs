using System;
using System.Collections.Generic;

namespace Keylogger
{
    public static class KeyCodesTranslator
    {
        private static Dictionary<string, string> keysWithTranslations;
        public static bool IsInitialized { get; set; } = false;
        private static string newline = Environment.NewLine;

        /// <summary>
        /// Initializes tuples key-translation with all .Net Keys Enum values as keys, and assigns a translation to each of them.
        /// To read an explanation on each key, please refer to https://msdn.microsoft.com/es-es/library/system.windows.forms.keys(v=vs.110).aspx
        /// </summary>
        public static void Initialize()
        {
            keysWithTranslations = new Dictionary<string, string>();
            keysWithTranslations["A"] = "a";
            keysWithTranslations["Add"] = newline + "<Presses or holds Add>" + newline;
            keysWithTranslations["Alt"] = newline + "<Presses or holds Alt>" + newline;
            keysWithTranslations["Apps"] = newline + "<Presses or holds Apps>" + newline;
            keysWithTranslations["Attn"] = newline + "<Presses or holds Attn>" + newline;
            keysWithTranslations["B"] = "b";
            keysWithTranslations["Back"] = newline + "<Presses or holds Back>" + newline;
            keysWithTranslations["BrowserBack"] = newline + "<Presses or holds BrowserBack>" + newline;
            keysWithTranslations["BrowserFavorites"] = newline + "<Presses or holds BrowserFavorites>" + newline;
            keysWithTranslations["BrowserForward"] = newline + "<Presses or holds BrowserForward>" + newline;
            keysWithTranslations["BrowserHome"] = newline + "<Presses or holds BrowserHome>" + newline;
            keysWithTranslations["BrowserRefresh"] = newline + "<Presses or holds BrowserRefresh>" + newline;
            keysWithTranslations["BrowserSearch"] = newline + "<Presses or holds BrowserSearch>" + newline;
            keysWithTranslations["BrowserStop"] = newline + "<Presses or holds BrowserStop>" + newline;
            keysWithTranslations["C"] = "c";
            keysWithTranslations["Cancel"] = newline + "<Presses or holds Cancel>" + newline;
            keysWithTranslations["Capital"] = newline + "<Presses or holds Capital>" + newline;
            keysWithTranslations["CapsLock"] = newline + "<Presses or holds CapsLock>" + newline;
            keysWithTranslations["Clear"] = newline + "<Presses or holds Clear>" + newline;
            keysWithTranslations["Control"] = newline + "<Presses or holds Control>" + newline;
            keysWithTranslations["ControlKey"] = newline + "<Presses or holds ControlKey>" + newline;
            keysWithTranslations["Crsel"] = newline + "<Presses or holds Crsel>" + newline;
            keysWithTranslations["D"] = "d";
            keysWithTranslations["D0"] = newline + "<Presses or holds D0>" + newline;
            keysWithTranslations["D1"] = newline + "<Presses or holds D1>" + newline;
            keysWithTranslations["D2"] = newline + "<Presses or holds D2>" + newline;
            keysWithTranslations["D3"] = newline + "<Presses or holds D3>" + newline;
            keysWithTranslations["D4"] = newline + "<Presses or holds D4>" + newline;
            keysWithTranslations["D5"] = newline + "<Presses or holds D5>" + newline;
            keysWithTranslations["D6"] = newline + "<Presses or holds D6>" + newline;
            keysWithTranslations["D7"] = newline + "<Presses or holds D7>" + newline;
            keysWithTranslations["D8"] = newline + "<Presses or holds D8>" + newline;
            keysWithTranslations["D9"] = newline + "<Presses or holds D9>" + newline;
            keysWithTranslations["Decimal"] = newline + "<Presses or holds Decimal>" + newline;
            keysWithTranslations["Delete"] = newline + "<Presses or holds Delete>" + newline;
            keysWithTranslations["Divide"] = newline + "<Presses or holds Divide>" + newline;
            keysWithTranslations["Down"] = newline + "<Presses or holds Down>" + newline;
            keysWithTranslations["E"] = "e";
            keysWithTranslations["End"] = newline + "<Presses or holds End>" + newline;
            keysWithTranslations["Enter"] = newline + "<Presses or holds Enter>" + newline;
            keysWithTranslations["EraseEof"] = newline + "<Presses or holds EraseEof>" + newline;
            keysWithTranslations["Escape"] = newline + "<Presses or holds Escape>" + newline;
            keysWithTranslations["Execute"] = newline + "<Presses or holds Execute>" + newline;
            keysWithTranslations["Exsel"] = newline + "<Presses or holds Exsel>" + newline;
            keysWithTranslations["F"] = "f";
            keysWithTranslations["F1"] = newline + "<Presses or holds F1>" + newline;
            keysWithTranslations["F10"] = newline + "<Presses or holds F10>" + newline;
            keysWithTranslations["F11"] = newline + "<Presses or holds F11>" + newline;
            keysWithTranslations["F12"] = newline + "<Presses or holds F12>" + newline;
            keysWithTranslations["F13"] = newline + "<Presses or holds F13>" + newline;
            keysWithTranslations["F14"] = newline + "<Presses or holds F14>" + newline;
            keysWithTranslations["F15"] = newline + "<Presses or holds F15>" + newline;
            keysWithTranslations["F16"] = newline + "<Presses or holds F16>" + newline;
            keysWithTranslations["F17"] = newline + "<Presses or holds F17>" + newline;
            keysWithTranslations["F18"] = newline + "<Presses or holds F18>" + newline;
            keysWithTranslations["F19"] = newline + "<Presses or holds F19>" + newline;
            keysWithTranslations["F2"] = newline + "<Presses or holds F2>" + newline;
            keysWithTranslations["F20"] = newline + "<Presses or holds F20>" + newline;
            keysWithTranslations["F21"] = newline + "<Presses or holds F21>" + newline;
            keysWithTranslations["F22"] = newline + "<Presses or holds F22>" + newline;
            keysWithTranslations["F23"] = newline + "<Presses or holds F23>" + newline;
            keysWithTranslations["F24"] = newline + "<Presses or holds F24>" + newline;
            keysWithTranslations["F3"] = newline + "<Presses or holds F3>" + newline;
            keysWithTranslations["F4"] = newline + "<Presses or holds F4>" + newline;
            keysWithTranslations["F5"] = newline + "<Presses or holds F5>" + newline;
            keysWithTranslations["F6"] = newline + "<Presses or holds F6>" + newline;
            keysWithTranslations["F7"] = newline + "<Presses or holds F7>" + newline;
            keysWithTranslations["F8"] = newline + "<Presses or holds F8>" + newline;
            keysWithTranslations["F9"] = newline + "<Presses or holds F9>" + newline;
            keysWithTranslations["FinalMode"] = newline + "<Presses or holds FinalMode>" + newline;
            keysWithTranslations["G"] = "g";
            keysWithTranslations["H"] = "h";
            keysWithTranslations["HanguelMode"] = newline + "<Presses or holds HanguelMode>" + newline;
            keysWithTranslations["HangulMode"] = newline + "<Presses or holds HangulMode>" + newline;
            keysWithTranslations["HanjaMode"] = newline + "<Presses or holds HanjaMode>" + newline;
            keysWithTranslations["Help"] = newline + "<Presses or holds Help>" + newline;
            keysWithTranslations["Home"] = newline + "<Presses or holds Home>" + newline;
            keysWithTranslations["I"] = "i";
            keysWithTranslations["IMEAccept"] = newline + "<Presses or holds IMEAccept>" + newline;
            keysWithTranslations["IMEAceept"] = newline + "<Presses or holds IMEAceept>" + newline;
            keysWithTranslations["IMEConvert"] = newline + "<Presses or holds IMEConvert>" + newline;
            keysWithTranslations["IMEModeChange"] = newline + "<Presses or holds IMEModeChange>" + newline;
            keysWithTranslations["IMENonconvert"] = newline + "<Presses or holds IMENonconvert>" + newline;
            keysWithTranslations["Insert"] = newline + "<Presses or holds Insert>" + newline;
            keysWithTranslations["J"] = "j";
            keysWithTranslations["JunjaMode"] = newline + "<Presses or holds JunjaMode>" + newline;
            keysWithTranslations["K"] = "k";
            keysWithTranslations["KanaMode"] = newline + "<Presses or holds KanaMode>" + newline;
            keysWithTranslations["KanjiMode"] = newline + "<Presses or holds KanjiMode>" + newline;
            keysWithTranslations["KeyCode"] = newline + "<Presses or holds KeyCode>" + newline;
            keysWithTranslations["L"] = "l";
            keysWithTranslations["LaunchApplication1"] = newline + "<Presses or holds LaunchApplication1>" + newline;
            keysWithTranslations["LaunchApplication2"] = newline + "<Presses or holds LaunchApplication2>" + newline;
            keysWithTranslations["LaunchMail"] = newline + "<Presses or holds LaunchMail>" + newline;
            keysWithTranslations["LButton"] = newline + "<Presses or holds LButton>" + newline;
            keysWithTranslations["LControlKey"] = newline + "<Presses or holds LControlKey>" + newline;
            keysWithTranslations["Left"] = newline + "<Presses or holds Left>" + newline;
            keysWithTranslations["LineFeed"] = newline + "<Presses or holds LineFeed>" + newline;
            keysWithTranslations["LMenu"] = newline + "<Presses or holds LMenu>" + newline;
            keysWithTranslations["LShiftKey"] = newline + "<Presses or holds LShiftKey>" + newline;
            keysWithTranslations["LWin"] = newline + "<Presses or holds LWin>" + newline;
            keysWithTranslations["M"] = "m";
            keysWithTranslations["MButton"] = newline + "<Presses or holds MButton>" + newline;
            keysWithTranslations["MediaNextTrack"] = newline + "<Presses or holds MediaNextTrack>" + newline;
            keysWithTranslations["MediaPlayPause"] = newline + "<Presses or holds MediaPlayPause>" + newline;
            keysWithTranslations["MediaPreviousTrack"] = newline + "<Presses or holds MediaPreviousTrack>" + newline;
            keysWithTranslations["MediaStop"] = newline + "<Presses or holds MediaStop>" + newline;
            keysWithTranslations["Menu"] = newline + "<Presses or holds Menu>" + newline;
            keysWithTranslations["Modifiers"] = newline + "<Presses or holds Modifiers>" + newline;
            keysWithTranslations["Multiply"] = newline + "<Presses or holds Multiply>" + newline;
            keysWithTranslations["N"] = "n";
            keysWithTranslations["Next"] = newline + "<Presses or holds Next>" + newline;
            keysWithTranslations["NoName"] = newline + "<Presses or holds NoName>" + newline;
            keysWithTranslations["None"] = newline + "<Presses or holds None>" + newline;
            keysWithTranslations["NumLock"] = newline + "<Presses or holds NumLock>" + newline;
            keysWithTranslations["NumPad0"] = newline + "<Presses or holds NumPad0>" + newline;
            keysWithTranslations["NumPad1"] = newline + "<Presses or holds NumPad1>" + newline;
            keysWithTranslations["NumPad2"] = newline + "<Presses or holds NumPad2>" + newline;
            keysWithTranslations["NumPad3"] = newline + "<Presses or holds NumPad3>" + newline;
            keysWithTranslations["NumPad4"] = newline + "<Presses or holds NumPad4>" + newline;
            keysWithTranslations["NumPad5"] = newline + "<Presses or holds NumPad5>" + newline;
            keysWithTranslations["NumPad6"] = newline + "<Presses or holds NumPad6>" + newline;
            keysWithTranslations["NumPad7"] = newline + "<Presses or holds NumPad7>" + newline;
            keysWithTranslations["NumPad8"] = newline + "<Presses or holds NumPad8>" + newline;
            keysWithTranslations["NumPad9"] = newline + "<Presses or holds NumPad9>" + newline;
            keysWithTranslations["O"] = "o";
            keysWithTranslations["Oem1"] = newline + "<Presses or holds Oem1>" + newline;
            keysWithTranslations["Oem102"] = newline + "<Presses or holds Oem102>" + newline;
            keysWithTranslations["Oem2"] = newline + "<Presses or holds Oem2>" + newline;
            keysWithTranslations["Oem3"] = newline + "<Presses or holds Oem3>" + newline;
            keysWithTranslations["Oem4"] = newline + "<Presses or holds Oem4>" + newline;
            keysWithTranslations["Oem5"] = newline + "<Presses or holds Oem5>" + newline;
            keysWithTranslations["Oem6"] = newline + "<Presses or holds Oem6>" + newline;
            keysWithTranslations["Oem7"] = newline + "<Presses or holds Oem7>" + newline;
            keysWithTranslations["Oem8"] = newline + "<Presses or holds Oem8>" + newline;
            keysWithTranslations["OemBackslash"] = newline + "<Presses or holds OemBackslash>" + newline;
            keysWithTranslations["OemClear"] = newline + "<Presses or holds OemClear>" + newline;
            keysWithTranslations["OemCloseBrackets"] = newline + "<Presses or holds OemCloseBrackets>" + newline;
            keysWithTranslations["Oemcomma"] = newline + "<Presses or holds Oemcomma>" + newline;
            keysWithTranslations["OemMinus"] = newline + "<Presses or holds OemMinus>" + newline;
            keysWithTranslations["OemOpenBrackets"] = newline + "<Presses or holds OemOpenBrackets>" + newline;
            keysWithTranslations["OemPeriod"] = newline + "<Presses or holds OemPeriod>" + newline;
            keysWithTranslations["OemPipe"] = newline + "<Presses or holds OemPipe>" + newline;
            keysWithTranslations["Oemplus"] = newline + "<Presses or holds Oemplus>" + newline;
            keysWithTranslations["OemQuestion"] = newline + "<Presses or holds OemQuestion>" + newline;
            keysWithTranslations["OemQuotes"] = newline + "<Presses or holds OemQuotes>" + newline;
            keysWithTranslations["OemSemicolon"] = newline + "<Presses or holds OemSemicolon>" + newline;
            keysWithTranslations["Oemtilde"] = newline + "<Presses or holds Oemtilde>" + newline;
            keysWithTranslations["P"] = "p";
            keysWithTranslations["Pa1"] = newline + "<Presses or holds Pa1>" + newline;
            keysWithTranslations["Packet"] = newline + "<Presses or holds Packet>" + newline;
            keysWithTranslations["PageDown"] = newline + "<Presses or holds PageDown>" + newline;
            keysWithTranslations["PageUp"] = newline + "<Presses or holds PageUp>" + newline;
            keysWithTranslations["Pause"] = newline + "<Presses or holds Pause>" + newline;
            keysWithTranslations["Play"] = newline + "<Presses or holds Play>" + newline;
            keysWithTranslations["Print"] = newline + "<Presses or holds Print>" + newline;
            keysWithTranslations["PrintScreen"] = newline + "<Presses or holds PrintScreen>" + newline;
            keysWithTranslations["Prior"] = newline + "<Presses or holds Prior>" + newline;
            keysWithTranslations["ProcessKey"] = newline + "<Presses or holds ProcessKey>" + newline;
            keysWithTranslations["Q"] = "q";
            keysWithTranslations["R"] = "r";
            keysWithTranslations["RButton"] = newline + "<Presses or holds RButton>" + newline;
            keysWithTranslations["RControlKey"] = newline + "<Presses or holds RControlKey>" + newline;
            keysWithTranslations["Return"] = newline + "<Presses or holds Return>" + newline;
            keysWithTranslations["Right"] = newline + "<Presses or holds Right>" + newline;
            keysWithTranslations["RMenu"] = newline + "<Presses or holds RMenu>" + newline;
            keysWithTranslations["RShiftKey"] = newline + "<Presses or holds RShiftKey>" + newline;
            keysWithTranslations["RWin"] = newline + "<Presses or holds RWin>" + newline;
            keysWithTranslations["S"] = "s";
            keysWithTranslations["Scroll"] = newline + "<Presses or holds Scroll>" + newline;
            keysWithTranslations["Select"] = newline + "<Presses or holds Select>" + newline;
            keysWithTranslations["SelectMedia"] = newline + "<Presses or holds SelectMedia>" + newline;
            keysWithTranslations["Separator"] = newline + "<Presses or holds Separator>" + newline;
            keysWithTranslations["Shift"] = newline + "<Presses or holds Shift>" + newline;
            keysWithTranslations["ShiftKey"] = newline + "<Presses or holds ShiftKey>" + newline;
            keysWithTranslations["Sleep"] = newline + "<Presses or holds Sleep>" + newline;
            keysWithTranslations["Snapshot"] = newline + "<Presses or holds Snapshot>" + newline;
            keysWithTranslations["Space"] = " ";
            keysWithTranslations["Subtract"] = newline + "<Presses or holds Subtract>" + newline;
            keysWithTranslations["T"] = "t";
            keysWithTranslations["Tab"] = newline + "<Presses or holds Tab>" + newline;
            keysWithTranslations["U"] = "u";
            keysWithTranslations["Up"] = newline + "<Presses or holds Up>" + newline;
            keysWithTranslations["V"] = "v";
            keysWithTranslations["VolumeDown"] = newline + "<Presses or holds VolumeDown>" + newline;
            keysWithTranslations["VolumeMute"] = newline + "<Presses or holds VolumeMute>" + newline;
            keysWithTranslations["VolumeUp"] = newline + "<Presses or holds VolumeUp>" + newline;
            keysWithTranslations["W"] = "w";
            keysWithTranslations["X"] = "x";
            keysWithTranslations["XButton1"] = newline + "<Presses or holds XButton1>" + newline;
            keysWithTranslations["XButton2"] = newline + "<Presses or holds XButton2>" + newline;
            keysWithTranslations["Y"] = "y";
            keysWithTranslations["Z"] = "z";
            keysWithTranslations["Zoom"] = newline + "<Presses or holds Zoom>" + newline;
            IsInitialized = true;
        }

        public static string TranslateKeyCodesIntoLegibleText(string keyCodeAsString)
        {
            if (!IsInitialized)
                Initialize();
            string resultText = keyCodeAsString;
            bool weKnowTheKey = keysWithTranslations.ContainsKey(keyCodeAsString);
            if (weKnowTheKey)
                resultText = keysWithTranslations[keyCodeAsString];
            else
                resultText = newline + "<OPERACION DESCONOCIDA>" + newline;
            return resultText;
        }
    }
}
