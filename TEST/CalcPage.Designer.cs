﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 16.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TEST.CalcPageClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public partial class CalcPage
    {
        
        #region Properties
        public UICalculatorWindow UICalculatorWindow
        {
            get
            {
                if ((this.mUICalculatorWindow == null))
                {
                    this.mUICalculatorWindow = new UICalculatorWindow();
                }
                return this.mUICalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICalculatorWindow mUICalculatorWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UICalculatorWindow : WinWindow
    {
        
        public UICalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public UIItemOutput UIItemOutput
        {
            get
            {
                if ((this.mUIItemOutput == null))
                {
                    this.mUIItemOutput = new UIItemOutput(this);
                }
                return this.mUIItemOutput;
            }
        }
        
        public UIItemClear UIItemClear
        {
            get
            {
                if ((this.mUIItemClear == null))
                {
                    this.mUIItemClear = new UIItemClear(this);
                }
                return this.mUIItemClear;
            }
        }
        
        public UIItem7 UIItem7
        {
            get
            {
                if ((this.mUIItem7 == null))
                {
                    this.mUIItem7 = new UIItem7(this);
                }
                return this.mUIItem7;
            }
        }
        
        public UIItem8 UIItem8
        {
            get
            {
                if ((this.mUIItem8 == null))
                {
                    this.mUIItem8 = new UIItem8(this);
                }
                return this.mUIItem8;
            }
        }
        
        public UIItem9 UIItem9
        {
            get
            {
                if ((this.mUIItem9 == null))
                {
                    this.mUIItem9 = new UIItem9(this);
                }
                return this.mUIItem9;
            }
        }
        
        public UIItem4 UIItem4
        {
            get
            {
                if ((this.mUIItem4 == null))
                {
                    this.mUIItem4 = new UIItem4(this);
                }
                return this.mUIItem4;
            }
        }
        
        public UIItem5 UIItem5
        {
            get
            {
                if ((this.mUIItem5 == null))
                {
                    this.mUIItem5 = new UIItem5(this);
                }
                return this.mUIItem5;
            }
        }
        
        public UIItem6 UIItem6
        {
            get
            {
                if ((this.mUIItem6 == null))
                {
                    this.mUIItem6 = new UIItem6(this);
                }
                return this.mUIItem6;
            }
        }
        
        public UIItem1 UIItem1
        {
            get
            {
                if ((this.mUIItem1 == null))
                {
                    this.mUIItem1 = new UIItem1(this);
                }
                return this.mUIItem1;
            }
        }
        
        public UIItem2 UIItem2
        {
            get
            {
                if ((this.mUIItem2 == null))
                {
                    this.mUIItem2 = new UIItem2(this);
                }
                return this.mUIItem2;
            }
        }
        
        public UIItem3 UIItem3
        {
            get
            {
                if ((this.mUIItem3 == null))
                {
                    this.mUIItem3 = new UIItem3(this);
                }
                return this.mUIItem3;
            }
        }
        
        public UIItem0 UIItem0
        {
            get
            {
                if ((this.mUIItem0 == null))
                {
                    this.mUIItem0 = new UIItem0(this);
                }
                return this.mUIItem0;
            }
        }
        
        public UIItemDivide UIItemDivide
        {
            get
            {
                if ((this.mUIItemDivide == null))
                {
                    this.mUIItemDivide = new UIItemDivide(this);
                }
                return this.mUIItemDivide;
            }
        }
        
        public UIItemMultiply UIItemMultiply
        {
            get
            {
                if ((this.mUIItemMultiply == null))
                {
                    this.mUIItemMultiply = new UIItemMultiply(this);
                }
                return this.mUIItemMultiply;
            }
        }
        
        public UIItemSubtract UIItemSubtract
        {
            get
            {
                if ((this.mUIItemSubtract == null))
                {
                    this.mUIItemSubtract = new UIItemSubtract(this);
                }
                return this.mUIItemSubtract;
            }
        }
        
        public UIItemAdd UIItemAdd
        {
            get
            {
                if ((this.mUIItemAdd == null))
                {
                    this.mUIItemAdd = new UIItemAdd(this);
                }
                return this.mUIItemAdd;
            }
        }
        
        public UIItemEquals UIItemEquals
        {
            get
            {
                if ((this.mUIItemEquals == null))
                {
                    this.mUIItemEquals = new UIItemEquals(this);
                }
                return this.mUIItemEquals;
            }
        }
        #endregion
        
        #region Fields
        private UIItemOutput mUIItemOutput;
        
        private UIItemClear mUIItemClear;
        
        private UIItem7 mUIItem7;
        
        private UIItem8 mUIItem8;
        
        private UIItem9 mUIItem9;
        
        private UIItem4 mUIItem4;
        
        private UIItem5 mUIItem5;
        
        private UIItem6 mUIItem6;
        
        private UIItem1 mUIItem1;
        
        private UIItem2 mUIItem2;
        
        private UIItem3 mUIItem3;
        
        private UIItem0 mUIItem0;
        
        private UIItemDivide mUIItemDivide;
        
        private UIItemMultiply mUIItemMultiply;
        
        private UIItemSubtract mUIItemSubtract;
        
        private UIItemAdd mUIItemAdd;
        
        private UIItemEquals mUIItemEquals;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItemOutput : WinWindow
    {
        
        public UIItemOutput(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "150";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinText UIOutputText
        {
            get
            {
                if ((this.mUIOutputText == null))
                {
                    this.mUIOutputText = new WinText(this);
                    #region Search Criteria
                    this.mUIOutputText.SearchProperties[WinText.PropertyNames.Name] = "Result";
                    this.mUIOutputText.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIOutputText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIOutputText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItemClear : WinWindow
    {
        
        public UIItemClear(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "82";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIClearButton
        {
            get
            {
                if ((this.mUIClearButton == null))
                {
                    this.mUIClearButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIClearButton.SearchProperties[WinButton.PropertyNames.Name] = "Clear entry";
                    this.mUIClearButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIClearButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIClearButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem7 : WinWindow
    {
        
        public UIItem7(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "137";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI7Button
        {
            get
            {
                if ((this.mUI7Button == null))
                {
                    this.mUI7Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI7Button.SearchProperties[WinButton.PropertyNames.Name] = "7";
                    this.mUI7Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI7Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI7Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem8 : WinWindow
    {
        
        public UIItem8(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "138";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI8Button
        {
            get
            {
                if ((this.mUI8Button == null))
                {
                    this.mUI8Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI8Button.SearchProperties[WinButton.PropertyNames.Name] = "8";
                    this.mUI8Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI8Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI8Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem9 : WinWindow
    {
        
        public UIItem9(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "139";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI9Button
        {
            get
            {
                if ((this.mUI9Button == null))
                {
                    this.mUI9Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI9Button.SearchProperties[WinButton.PropertyNames.Name] = "9";
                    this.mUI9Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI9Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI9Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem4 : WinWindow
    {
        
        public UIItem4(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "134";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI4Button
        {
            get
            {
                if ((this.mUI4Button == null))
                {
                    this.mUI4Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI4Button.SearchProperties[WinButton.PropertyNames.Name] = "4";
                    this.mUI4Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI4Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI4Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem5 : WinWindow
    {
        
        public UIItem5(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "135";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI5Button
        {
            get
            {
                if ((this.mUI5Button == null))
                {
                    this.mUI5Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI5Button.SearchProperties[WinButton.PropertyNames.Name] = "5";
                    this.mUI5Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI5Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI5Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem6 : WinWindow
    {
        
        public UIItem6(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "136";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI6Button
        {
            get
            {
                if ((this.mUI6Button == null))
                {
                    this.mUI6Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI6Button.SearchProperties[WinButton.PropertyNames.Name] = "6";
                    this.mUI6Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI6Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI6Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem1 : WinWindow
    {
        
        public UIItem1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "131";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI1Button
        {
            get
            {
                if ((this.mUI1Button == null))
                {
                    this.mUI1Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI1Button.SearchProperties[WinButton.PropertyNames.Name] = "1";
                    this.mUI1Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI1Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI1Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem2 : WinWindow
    {
        
        public UIItem2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "132";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI2Button
        {
            get
            {
                if ((this.mUI2Button == null))
                {
                    this.mUI2Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI2Button.SearchProperties[WinButton.PropertyNames.Name] = "2";
                    this.mUI2Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI2Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI2Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem3 : WinWindow
    {
        
        public UIItem3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "133";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI3Button
        {
            get
            {
                if ((this.mUI3Button == null))
                {
                    this.mUI3Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI3Button.SearchProperties[WinButton.PropertyNames.Name] = "3";
                    this.mUI3Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI3Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI3Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItem0 : WinWindow
    {
        
        public UIItem0(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "130";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UI0Button
        {
            get
            {
                if ((this.mUI0Button == null))
                {
                    this.mUI0Button = new WinButton(this);
                    #region Search Criteria
                    this.mUI0Button.SearchProperties[WinButton.PropertyNames.Name] = "0";
                    this.mUI0Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUI0Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI0Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItemDivide : WinWindow
    {
        
        public UIItemDivide(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "91";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIDivideButton
        {
            get
            {
                if ((this.mUIDivideButton == null))
                {
                    this.mUIDivideButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIDivideButton.SearchProperties[WinButton.PropertyNames.Name] = "Divide";
                    this.mUIDivideButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIDivideButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIDivideButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItemMultiply : WinWindow
    {
        
        public UIItemMultiply(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "92";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIMultiplyButton
        {
            get
            {
                if ((this.mUIMultiplyButton == null))
                {
                    this.mUIMultiplyButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIMultiplyButton.SearchProperties[WinButton.PropertyNames.Name] = "Multiply";
                    this.mUIMultiplyButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIMultiplyButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIMultiplyButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItemSubtract : WinWindow
    {
        
        public UIItemSubtract(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "94";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UISubtractButton
        {
            get
            {
                if ((this.mUISubtractButton == null))
                {
                    this.mUISubtractButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISubtractButton.SearchProperties[WinButton.PropertyNames.Name] = "Subtract";
                    this.mUISubtractButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUISubtractButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISubtractButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItemAdd : WinWindow
    {
        
        public UIItemAdd(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "93";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIAddButton
        {
            get
            {
                if ((this.mUIAddButton == null))
                {
                    this.mUIAddButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAddButton.SearchProperties[WinButton.PropertyNames.Name] = "Add";
                    this.mUIAddButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIAddButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAddButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.32802.440")]
    public class UIItemEquals : WinWindow
    {
        
        public UIItemEquals(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "121";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIEqualsButton
        {
            get
            {
                if ((this.mUIEqualsButton == null))
                {
                    this.mUIEqualsButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIEqualsButton.SearchProperties[WinButton.PropertyNames.Name] = "Equals";
                    this.mUIEqualsButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIEqualsButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIEqualsButton;
        #endregion
    }
}
