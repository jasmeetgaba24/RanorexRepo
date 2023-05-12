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
    ///The AddEntry recording.
    /// </summary>
    [TestModule("292288a8-dc08-4208-838e-437dae92b9f3", ModuleType.Recording, 1)]
    public partial class AddEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::KeePassApplicationTest.KeePassApplicationTestRepository repository.
        /// </summary>
        public static global::KeePassApplicationTest.KeePassApplicationTestRepository repo = global::KeePassApplicationTest.KeePassApplicationTestRepository.Instance;

        static AddEntry instance = new AddEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEntry()
        {
            varTitle = "Title Value";
            varUserName = "Username Value";
            varPassword = "Password Value";
            varComment = "Comment Value";
            varURL = "URl Value";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddEntry Instance
        {
            get { return instance; }
        }

#region Variables

        string _varTitle;

        /// <summary>
        /// Gets or sets the value of variable varTitle.
        /// </summary>
        [TestVariable("8a120f84-a85e-4245-9031-29d9760d3032")]
        public string varTitle
        {
            get { return _varTitle; }
            set { _varTitle = value; }
        }

        string _varUserName;

        /// <summary>
        /// Gets or sets the value of variable varUserName.
        /// </summary>
        [TestVariable("f7506b7d-d92a-43c1-9efa-6e1178810d81")]
        public string varUserName
        {
            get { return _varUserName; }
            set { _varUserName = value; }
        }

        string _varPassword;

        /// <summary>
        /// Gets or sets the value of variable varPassword.
        /// </summary>
        [TestVariable("6d9f5175-59b7-4ed2-b6b6-75f42f65ebae")]
        public string varPassword
        {
            get { return _varPassword; }
            set { _varPassword = value; }
        }

        string _varComment;

        /// <summary>
        /// Gets or sets the value of variable varComment.
        /// </summary>
        [TestVariable("02194aeb-d1bb-448c-8305-f46f92752b28")]
        public string varComment
        {
            get { return _varComment; }
            set { _varComment = value; }
        }

        string _varURL;

        /// <summary>
        /// Gets or sets the value of variable varURL.
        /// </summary>
        [TestVariable("f143e91c-f9d1-44d5-8176-8c8a651bec51")]
        public string varURL
        {
            get { return _varURL; }
            set { _varURL = value; }
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComAndroidKeepass.AddInternet.Internet' at Center", repo.ComAndroidKeepass.AddInternet.InternetInfo, new RecordItemIndex(0));
            repo.ComAndroidKeepass.AddInternet.Internet.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComAndroidKeepass.AddInternet.AddEntry' at Center", repo.ComAndroidKeepass.AddInternet.AddEntryInfo, new RecordItemIndex(1));
            repo.ComAndroidKeepass.AddInternet.AddEntry.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComAndroidKeepass.AddInternet.IconButton' at Center", repo.ComAndroidKeepass.AddInternet.IconButtonInfo, new RecordItemIndex(2));
            repo.ComAndroidKeepass.AddInternet.IconButton.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComAndroidKeepass.AddInternet.Icon' at Center", repo.ComAndroidKeepass.AddInternet.IconInfo, new RecordItemIndex(3));
            repo.ComAndroidKeepass.AddInternet.Icon.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$varTitle' on item 'ComAndroidKeepass.AddInternet.EntryTitle'.", repo.ComAndroidKeepass.AddInternet.EntryTitleInfo, new RecordItemIndex(4));
            repo.ComAndroidKeepass.AddInternet.EntryTitle.Element.SetAttributeValue("Text", varTitle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$varUserName' on item 'ComAndroidKeepass.AddInternet.EntryUserName'.", repo.ComAndroidKeepass.AddInternet.EntryUserNameInfo, new RecordItemIndex(5));
            repo.ComAndroidKeepass.AddInternet.EntryUserName.Element.SetAttributeValue("Text", varUserName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$varURL' on item 'ComAndroidKeepass.AddInternet.EntryUrl'.", repo.ComAndroidKeepass.AddInternet.EntryUrlInfo, new RecordItemIndex(6));
            repo.ComAndroidKeepass.AddInternet.EntryUrl.Element.SetAttributeValue("Text", varURL);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$varPassword' on item 'ComAndroidKeepass.AddInternet.EntryPassword'.", repo.ComAndroidKeepass.AddInternet.EntryPasswordInfo, new RecordItemIndex(7));
            repo.ComAndroidKeepass.AddInternet.EntryPassword.Element.SetAttributeValue("Text", varPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$varPassword' on item 'ComAndroidKeepass.AddInternet.EntryConfpassword'.", repo.ComAndroidKeepass.AddInternet.EntryConfpasswordInfo, new RecordItemIndex(8));
            repo.ComAndroidKeepass.AddInternet.EntryConfpassword.Element.SetAttributeValue("Text", varPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$varComment' on item 'ComAndroidKeepass.AddInternet.EntryComment'.", repo.ComAndroidKeepass.AddInternet.EntryCommentInfo, new RecordItemIndex(9));
            repo.ComAndroidKeepass.AddInternet.EntryComment.Element.SetAttributeValue("Text", varComment);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComAndroidKeepass.AddInternet.EntrySave' at Center", repo.ComAndroidKeepass.AddInternet.EntrySaveInfo, new RecordItemIndex(10));
            repo.ComAndroidKeepass.AddInternet.EntrySave.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
