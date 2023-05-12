﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace KeePassApplicationTest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateEntry recording.
    /// </summary>
    [TestModule("7b6df78c-db0f-400b-a574-c135803db5dd", ModuleType.Recording, 1)]
    public partial class ValidateEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::KeePassApplicationTest.KeePassApplicationTestRepository repository.
        /// </summary>
        public static global::KeePassApplicationTest.KeePassApplicationTestRepository repo = global::KeePassApplicationTest.KeePassApplicationTestRepository.Instance;

        static ValidateEntry instance = new ValidateEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateEntry()
        {
            varTitle = "Title Value";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateEntry Instance
        {
            get { return instance; }
        }

#region Variables

        string _varTitle;

        /// <summary>
        /// Gets or sets the value of variable varTitle.
        /// </summary>
        [TestVariable("8fd239a9-3284-402b-abd3-bd0a5664b85d")]
        public string varTitle
        {
            get { return _varTitle; }
            set { _varTitle = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$varTitle) on item 'ComAndroidKeepass.AddInternet.ValidateTitle'.", repo.ComAndroidKeepass.AddInternet.ValidateTitleInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ComAndroidKeepass.AddInternet.ValidateTitleInfo, "Text", varTitle);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
