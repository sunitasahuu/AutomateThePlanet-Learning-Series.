// <copyright file="FileUploader.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using System;

namespace HowToCreateGenericDialogHandlers
{
    public static class FileUploader
    {
        public static void Upload(Action action, string filePath)
        {
            Manager.Current.ActiveBrowser.Window.Maximize();
            var dialog = new FileUploadDialog(
                Manager.Current.ActiveBrowser, 
                filePath, 
                DialogButton.OPEN, 
                "OPEN");
            try
            {
                Manager.Current.DialogMonitor.AddDialog(dialog);
                Manager.Current.ActiveBrowser.RefreshDomTree();
                action();
                dialog.WaitUntilHandled();
            }
            finally
            {
                Manager.Current.DialogMonitor.RemoveDialog(dialog);
            }
        }
    }
}