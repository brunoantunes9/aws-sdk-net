/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the recurring schedule for a Scheduled Instance.
    /// </summary>
    public partial class ScheduledInstanceRecurrenceRequest
    {
        private string _frequency;
        private int? _interval;
        private List<int> _occurrenceDays = new List<int>();
        private bool? _occurrenceRelativeToEnd;
        private string _occurrenceUnit;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The frequency (<code>Daily</code>, <code>Weekly</code>, or <code>Monthly</code>).
        /// </para>
        /// </summary>
        public string Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval quantity. The interval unit depends on the value of <code>Frequency</code>.
        /// For example, every 2 weeks or every 2 months.
        /// </para>
        /// </summary>
        public int Interval
        {
            get { return this._interval.GetValueOrDefault(); }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OccurrenceDays. 
        /// <para>
        /// The days. For a monthly schedule, this is one or more days of the month (1-31). For
        /// a weekly schedule, this is one or more days of the week (1-7, where 1 is Sunday).
        /// You can't specify this value with a daily schedule. If the occurrence is relative
        /// to the end of the month, you can specify only a single day.
        /// </para>
        /// </summary>
        public List<int> OccurrenceDays
        {
            get { return this._occurrenceDays; }
            set { this._occurrenceDays = value; }
        }

        // Check to see if OccurrenceDays property is set
        internal bool IsSetOccurrenceDays()
        {
            return this._occurrenceDays != null && this._occurrenceDays.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OccurrenceRelativeToEnd. 
        /// <para>
        /// Indicates whether the occurrence is relative to the end of the specified week or month.
        /// You can't specify this value with a daily schedule.
        /// </para>
        /// </summary>
        public bool OccurrenceRelativeToEnd
        {
            get { return this._occurrenceRelativeToEnd.GetValueOrDefault(); }
            set { this._occurrenceRelativeToEnd = value; }
        }

        // Check to see if OccurrenceRelativeToEnd property is set
        internal bool IsSetOccurrenceRelativeToEnd()
        {
            return this._occurrenceRelativeToEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OccurrenceUnit. 
        /// <para>
        /// The unit for <code>OccurrenceDays</code> (<code>DayOfWeek</code> or <code>DayOfMonth</code>).
        /// This value is required for a monthly schedule. You can't specify <code>DayOfWeek</code>
        /// with a weekly schedule. You can't specify this value with a daily schedule.
        /// </para>
        /// </summary>
        public string OccurrenceUnit
        {
            get { return this._occurrenceUnit; }
            set { this._occurrenceUnit = value; }
        }

        // Check to see if OccurrenceUnit property is set
        internal bool IsSetOccurrenceUnit()
        {
            return this._occurrenceUnit != null;
        }

    }
}