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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace StepEditText
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the StepEditTextRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("168c80e3-9cb1-4de1-bf24-253fdbb2cfb1")]
    public partial class StepEditTextRepository : RepoGenBaseFolder
    {
        static StepEditTextRepository instance = new StepEditTextRepository();
        StepEditTextRepositoryFolders.SnapXUntitledAppFolder _snapxuntitled;
        StepEditTextRepositoryFolders.SnapXRoutineOneMxyAppFolder _snapxroutineonemxy;
        StepEditTextRepositoryFolders.SNAPXAppFolder _snapx;

        /// <summary>
        /// Gets the singleton class instance representing the StepEditTextRepository element repository.
        /// </summary>
        [RepositoryFolder("168c80e3-9cb1-4de1-bf24-253fdbb2cfb1")]
        public static StepEditTextRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public StepEditTextRepository() 
            : base("StepEditTextRepository", "/", null, 0, false, "168c80e3-9cb1-4de1-bf24-253fdbb2cfb1", ".\\RepositoryImages\\StepEditTextRepository168c80e3.rximgres")
        {
            _snapxuntitled = new StepEditTextRepositoryFolders.SnapXUntitledAppFolder(this);
            _snapxroutineonemxy = new StepEditTextRepositoryFolders.SnapXRoutineOneMxyAppFolder(this);
            _snapx = new StepEditTextRepositoryFolders.SNAPXAppFolder(this);
        }

#region Variables

        string _Snap_X = "Snap-X";

        /// <summary>
        /// Gets or sets the value of variable Snap_X.
        /// </summary>
        [TestVariable("0eac791c-85ea-45fb-9336-0cf2b08d1f0b")]
        public string Snap_X
        {
            get { return _Snap_X; }
            set { _Snap_X = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("168c80e3-9cb1-4de1-bf24-253fdbb2cfb1")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SnapXUntitled folder.
        /// </summary>
        [RepositoryFolder("a9305a84-2f66-455c-aef2-82851b726e91")]
        public virtual StepEditTextRepositoryFolders.SnapXUntitledAppFolder SnapXUntitled
        {
            get { return _snapxuntitled; }
        }

        /// <summary>
        /// The SnapXRoutineOneMxy folder.
        /// </summary>
        [RepositoryFolder("1d3d4dac-e57f-41bf-b13f-e60774ff7c44")]
        public virtual StepEditTextRepositoryFolders.SnapXRoutineOneMxyAppFolder SnapXRoutineOneMxy
        {
            get { return _snapxroutineonemxy; }
        }

        /// <summary>
        /// The SNAPX folder.
        /// </summary>
        [RepositoryFolder("9181e4fa-376a-410d-91d2-2e6976cec0e0")]
        public virtual StepEditTextRepositoryFolders.SNAPXAppFolder SNAPX
        {
            get { return _snapx; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class StepEditTextRepositoryFolders
    {
        /// <summary>
        /// The SnapXUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("a9305a84-2f66-455c-aef2-82851b726e91")]
        public partial class SnapXUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebarInfo;
            RepoItemInfo _measuretextInfo;
            RepoItemInfo _switchtosensorInfo;

            /// <summary>
            /// Creates a new SnapXUntitled  folder.
            /// </summary>
            public SnapXUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SnapXUntitled", "/form[@title='Snap-X - [Untitled]']", parentFolder, 30000, null, true, "a9305a84-2f66-455c-aef2-82851b726e91", "")
            {
                _titlebarInfo = new RepoItemInfo(this, "TitleBar", "element[@controlid='94']", 30000, null, "e13b0b88-e730-45ee-ab03-0e6da882202f");
                _measuretextInfo = new RepoItemInfo(this, "MeasureText", "container[@controlid='59648']/form[@title='Untitled']//text[@controlid='2394']", 30000, null, "b40832c7-c2a3-4189-a614-91eb7bf864c9");
                _switchtosensorInfo = new RepoItemInfo(this, "SwitchToSensor", "container[@controlid='59648']/form[@title='Untitled']/?/?/element[@controlid='59650']/element[@controlid='59648']/toolbar[@controlid='59392']/button[@commandid='40029']", 30000, null, "3f82f465-9166-4d08-b2ca-ab8a31ebbab1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a9305a84-2f66-455c-aef2-82851b726e91")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a9305a84-2f66-455c-aef2-82851b726e91")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar item.
            /// </summary>
            [RepositoryItem("e13b0b88-e730-45ee-ab03-0e6da882202f")]
            public virtual Ranorex.Unknown TitleBar
            {
                get
                {
                    return _titlebarInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The TitleBar item info.
            /// </summary>
            [RepositoryItemInfo("e13b0b88-e730-45ee-ab03-0e6da882202f")]
            public virtual RepoItemInfo TitleBarInfo
            {
                get
                {
                    return _titlebarInfo;
                }
            }

            /// <summary>
            /// The MeasureText item.
            /// </summary>
            [RepositoryItem("b40832c7-c2a3-4189-a614-91eb7bf864c9")]
            public virtual Ranorex.Text MeasureText
            {
                get
                {
                    return _measuretextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The MeasureText item info.
            /// </summary>
            [RepositoryItemInfo("b40832c7-c2a3-4189-a614-91eb7bf864c9")]
            public virtual RepoItemInfo MeasureTextInfo
            {
                get
                {
                    return _measuretextInfo;
                }
            }

            /// <summary>
            /// The SwitchToSensor item.
            /// </summary>
            [RepositoryItem("3f82f465-9166-4d08-b2ca-ab8a31ebbab1")]
            public virtual Ranorex.Button SwitchToSensor
            {
                get
                {
                    return _switchtosensorInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SwitchToSensor item info.
            /// </summary>
            [RepositoryItemInfo("3f82f465-9166-4d08-b2ca-ab8a31ebbab1")]
            public virtual RepoItemInfo SwitchToSensorInfo
            {
                get
                {
                    return _switchtosensorInfo;
                }
            }
        }

        /// <summary>
        /// The SnapXRoutineOneMxyAppFolder folder.
        /// </summary>
        [RepositoryFolder("1d3d4dac-e57f-41bf-b13f-e60774ff7c44")]
        public partial class SnapXRoutineOneMxyAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonokInfo;
            RepoItemInfo _finishInfo;
            RepoItemInfo _endatsteptextInfo;
            RepoItemInfo _prompttextInfo;
            RepoItemInfo _startatsteptextInfo;
            RepoItemInfo _titletextInfo;
            RepoItemInfo _wholewindowInfo;

            /// <summary>
            /// Creates a new SnapXRoutineOneMxy  folder.
            /// </summary>
            public SnapXRoutineOneMxyAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SnapXRoutineOneMxy", "/form[@title='Snap-X - [RoutineOne.mxy]']", parentFolder, 30000, null, true, "1d3d4dac-e57f-41bf-b13f-e60774ff7c44", "")
            {
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "container[@controlid='59648']/form[@title='RoutineOne.mxy']//button[@text='&OK']", 30000, null, "73a09665-64e4-4ad6-b928-f4f0c38553b4");
                _finishInfo = new RepoItemInfo(this, "Finish", "container[@controlid='59648']/form[@title='RoutineOne.mxy']//button[@text='Finish']", 30000, null, "9d0e283b-676b-4b7f-aa7a-1459e89edd8d");
                _endatsteptextInfo = new RepoItemInfo(this, "EndAtStepText", "container[@controlid='59648']/form[@title='RoutineOne.mxy']//text[@controlid='1326']", 30000, null, "44ddc625-f37f-4339-9426-ac85430607d8");
                _prompttextInfo = new RepoItemInfo(this, "PromptText", "container[@controlid='59648']/form[@title='RoutineOne.mxy']//text[@controlid='1157']", 30000, null, "d0fbedc2-6dcf-42c0-837e-21bc2f235b07");
                _startatsteptextInfo = new RepoItemInfo(this, "StartAtStepText", "container[@controlid='59648']/form[@title='RoutineOne.mxy']//text[@controlid='1325']", 30000, null, "c9471d41-283f-4566-83a3-a88de2143e26");
                _titletextInfo = new RepoItemInfo(this, "TitleText", "container[@controlid='59648']/form[@title='RoutineOne.mxy']//text[@controlid='1647']", 30000, null, "ba21d90f-f26d-406a-9357-434f561ab0f8");
                _wholewindowInfo = new RepoItemInfo(this, "WholeWindow", "container[@controlid='59648']/form[@title='RoutineOne.mxy']//container[@controlid='59648']", 30000, null, "7b684f40-1f5b-42b0-b222-74127314d428");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1d3d4dac-e57f-41bf-b13f-e60774ff7c44")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1d3d4dac-e57f-41bf-b13f-e60774ff7c44")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("73a09665-64e4-4ad6-b928-f4f0c38553b4")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("73a09665-64e4-4ad6-b928-f4f0c38553b4")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }

            /// <summary>
            /// The Finish item.
            /// </summary>
            [RepositoryItem("9d0e283b-676b-4b7f-aa7a-1459e89edd8d")]
            public virtual Ranorex.Button Finish
            {
                get
                {
                    return _finishInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Finish item info.
            /// </summary>
            [RepositoryItemInfo("9d0e283b-676b-4b7f-aa7a-1459e89edd8d")]
            public virtual RepoItemInfo FinishInfo
            {
                get
                {
                    return _finishInfo;
                }
            }

            /// <summary>
            /// The EndAtStepText item.
            /// </summary>
            [RepositoryItem("44ddc625-f37f-4339-9426-ac85430607d8")]
            public virtual Ranorex.Text EndAtStepText
            {
                get
                {
                    return _endatsteptextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EndAtStepText item info.
            /// </summary>
            [RepositoryItemInfo("44ddc625-f37f-4339-9426-ac85430607d8")]
            public virtual RepoItemInfo EndAtStepTextInfo
            {
                get
                {
                    return _endatsteptextInfo;
                }
            }

            /// <summary>
            /// The PromptText item.
            /// </summary>
            [RepositoryItem("d0fbedc2-6dcf-42c0-837e-21bc2f235b07")]
            public virtual Ranorex.Text PromptText
            {
                get
                {
                    return _prompttextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The PromptText item info.
            /// </summary>
            [RepositoryItemInfo("d0fbedc2-6dcf-42c0-837e-21bc2f235b07")]
            public virtual RepoItemInfo PromptTextInfo
            {
                get
                {
                    return _prompttextInfo;
                }
            }

            /// <summary>
            /// The StartAtStepText item.
            /// </summary>
            [RepositoryItem("c9471d41-283f-4566-83a3-a88de2143e26")]
            public virtual Ranorex.Text StartAtStepText
            {
                get
                {
                    return _startatsteptextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The StartAtStepText item info.
            /// </summary>
            [RepositoryItemInfo("c9471d41-283f-4566-83a3-a88de2143e26")]
            public virtual RepoItemInfo StartAtStepTextInfo
            {
                get
                {
                    return _startatsteptextInfo;
                }
            }

            /// <summary>
            /// The TitleText item.
            /// </summary>
            [RepositoryItem("ba21d90f-f26d-406a-9357-434f561ab0f8")]
            public virtual Ranorex.Text TitleText
            {
                get
                {
                    return _titletextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TitleText item info.
            /// </summary>
            [RepositoryItemInfo("ba21d90f-f26d-406a-9357-434f561ab0f8")]
            public virtual RepoItemInfo TitleTextInfo
            {
                get
                {
                    return _titletextInfo;
                }
            }

            /// <summary>
            /// The WholeWindow item.
            /// </summary>
            [RepositoryItem("7b684f40-1f5b-42b0-b222-74127314d428")]
            public virtual Ranorex.Container WholeWindow
            {
                get
                {
                    return _wholewindowInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The WholeWindow item info.
            /// </summary>
            [RepositoryItemInfo("7b684f40-1f5b-42b0-b222-74127314d428")]
            public virtual RepoItemInfo WholeWindowInfo
            {
                get
                {
                    return _wholewindowInfo;
                }
            }
        }

        /// <summary>
        /// The SNAPXAppFolder folder.
        /// </summary>
        [RepositoryFolder("9181e4fa-376a-410d-91d2-2e6976cec0e0")]
        public partial class SNAPXAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _snapxInfo;
            RepoItemInfo _savechangestextInfo;

            /// <summary>
            /// Creates a new SNAPX  folder.
            /// </summary>
            public SNAPXAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SNAPX", "/form[@title='SNAP-X']", parentFolder, 30000, null, true, "9181e4fa-376a-410d-91d2-2e6976cec0e0", "")
            {
                _snapxInfo = new RepoItemInfo(this, "SNAPX", "titlebar[@accessiblerole='TitleBar']", 30000, null, "40f55add-da64-4a49-91af-7ed7ed1798ba");
                _savechangestextInfo = new RepoItemInfo(this, "SaveChangesText", "text[@controlid='65535']", 30000, null, "e497df9b-24cc-453b-be49-50e8eb3866d0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9181e4fa-376a-410d-91d2-2e6976cec0e0")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9181e4fa-376a-410d-91d2-2e6976cec0e0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SNAPX item.
            /// </summary>
            [RepositoryItem("40f55add-da64-4a49-91af-7ed7ed1798ba")]
            public virtual Ranorex.TitleBar SNAPX
            {
                get
                {
                    return _snapxInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The SNAPX item info.
            /// </summary>
            [RepositoryItemInfo("40f55add-da64-4a49-91af-7ed7ed1798ba")]
            public virtual RepoItemInfo SNAPXInfo
            {
                get
                {
                    return _snapxInfo;
                }
            }

            /// <summary>
            /// The SaveChangesText item.
            /// </summary>
            [RepositoryItem("e497df9b-24cc-453b-be49-50e8eb3866d0")]
            public virtual Ranorex.Text SaveChangesText
            {
                get
                {
                    return _savechangestextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SaveChangesText item info.
            /// </summary>
            [RepositoryItemInfo("e497df9b-24cc-453b-be49-50e8eb3866d0")]
            public virtual RepoItemInfo SaveChangesTextInfo
            {
                get
                {
                    return _savechangestextInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}