/*
 * Created by Ranorex
 * User: jasmeetsingh59
 * Date: 5/11/2023
 * Time: 8:38 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace KeePassApplicationTest.CodeModules
{
    /// <summary>
    /// Description of CreateDatabaseAndLogin.
    /// </summary>
    [TestModule("A33DA62E-EBDB-4B6D-9A78-E9BA31100C3D", ModuleType.UserCode, 1)]
    public class CreateDatabaseAndLogin : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateDatabaseAndLogin()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
