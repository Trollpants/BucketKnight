// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TutorialPlayButton.cs" company="Jan Ivar Z. Carlsen">
// Copyright (c) 2018 Jan Ivar Z. Carlsen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BucketKnight
{
    public class TutorialPlayButton : CustomButton
    {
        protected override void OnButtonClicked()
        {
            Events.instance.Raise(new TutorialToggled(true));
            Events.instance.Raise(new GoInGame());
        }
    }
}
