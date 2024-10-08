// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> The TemperatureSummary. </summary>
    public partial class TemperatureSummary
    {
        /// <summary> Initializes a new instance of <see cref="TemperatureSummary"/>. </summary>
        internal TemperatureSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TemperatureSummary"/>. </summary>
        /// <param name="pastSixHours"> Summary of temperature fluctuations over the past 6 hours. </param>
        /// <param name="pastTwelveHours"> Summary of temperature fluctuations over the past 12 hours. </param>
        /// <param name="pastTwentyFourHours"> Summary of temperature fluctuations over the past 24 hours. </param>
        internal TemperatureSummary(PastHoursTemperature pastSixHours, PastHoursTemperature pastTwelveHours, PastHoursTemperature pastTwentyFourHours)
        {
            PastSixHours = pastSixHours;
            PastTwelveHours = pastTwelveHours;
            PastTwentyFourHours = pastTwentyFourHours;
        }

        /// <summary> Summary of temperature fluctuations over the past 6 hours. </summary>
        public PastHoursTemperature PastSixHours { get; }
        /// <summary> Summary of temperature fluctuations over the past 12 hours. </summary>
        public PastHoursTemperature PastTwelveHours { get; }
        /// <summary> Summary of temperature fluctuations over the past 24 hours. </summary>
        public PastHoursTemperature PastTwentyFourHours { get; }
    }
}
