/***************************************************************************

Copyright (c) Microsoft Corporation. All rights reserved.
This code is licensed under the Visual Studio SDK license terms.
THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

***************************************************************************/

using System;

namespace GitScc
{
    /// <summary>
    /// This class is used to expose the list of the IDs of the commands implemented
    /// by the client package. This list of IDs must match the set of IDs defined inside the
    /// VSCT file.
    /// </summary>
    static class CommandId
    {
        // Define the list a set of public static members.
        public const int icmdSccCommandRefresh = 0x101;
        public const int icmdSccCommandGitBash = 0x102;
        public const int icmdSccCommandGitExtension = 0x103;
        public const int icmdSccCommandCompare = 0x104;
        public const int icmdSccCommandUndo = 0x105;
        public const int icmdSccCommandBranchName = 0x106;

        //public const int icmdViewToolWindow = 0x102;
        //public const int icmdToolWindowToolbarCommand = 0x103;

        // Define the list of menus (these include toolbars)
        //public const int imnuToolWindowToolbarMenu = 0x200;
        public const int imnuFileSourceControlMenu = 0x205;

        // Define the list of icons (use decimal numbers here, to match the resource IDs)
        public const int iiconProductIcon = 400;

        // Define the list of bitmaps (use decimal numbers here, to match the resource IDs)
        //public const int ibmpToolbarMenusImages = 500;
        //public const int ibmpToolWindowsImages = 501;

        // Glyph indexes in the bitmap used for toolwindows (ibmpToolWindowsImages)
        //public const int iconSccProviderToolWindow = 0;
    }
}
