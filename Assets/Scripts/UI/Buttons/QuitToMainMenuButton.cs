﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuitToMainMenuButton.cs" company="Jan Ivar Z. Carlsen">
// Copyright (c) 2018 Jan Ivar Z. Carlsen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BucketKnight
{
    public class QuitToMainMenuButton : CustomButton
    {
        protected override void OnButtonClicked()
        {
            Events.instance.Raise(new QuitToMainMenu());
        }
    }
}
