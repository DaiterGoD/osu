﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Taiko.Judgements
{
    public class TaikoSwellJudgement : TaikoJudgement
    {
        /// <summary>
        /// The <see cref="HitResult"/> to grant when the player has hit more than half of swell ticks.
        /// </summary>
        public virtual HitResult PartialCompletionResult => HitResult.Ok;

        protected override double HealthIncreaseFor(HitResult result)
        {
            switch (result)
            {
                case HitResult.Miss:
                    return -0.65;

                default:
                    return 0;
            }
        }
    }
}
