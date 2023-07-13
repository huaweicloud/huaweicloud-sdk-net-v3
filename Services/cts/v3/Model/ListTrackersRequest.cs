using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.cts.v3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTrackersRequest 
    {
        /// <summary>
        /// 标识追踪器类型。 目前支持系统追踪器有管理类追踪器（system）和数据类追踪器（data）。
        /// </summary>
        /// <value>标识追踪器类型。 目前支持系统追踪器有管理类追踪器（system）和数据类追踪器（data）。</value>
        [JsonConverter(typeof(EnumClassConverter<TrackerTypeEnum>))]
        public class TrackerTypeEnum
        {
            /// <summary>
            /// Enum SYSTEM for value: system
            /// </summary>
            public static readonly TrackerTypeEnum SYSTEM = new TrackerTypeEnum("system");

            /// <summary>
            /// Enum DATA for value: data
            /// </summary>
            public static readonly TrackerTypeEnum DATA = new TrackerTypeEnum("data");

            private static readonly Dictionary<string, TrackerTypeEnum> StaticFields =
            new Dictionary<string, TrackerTypeEnum>()
            {
                { "system", SYSTEM },
                { "data", DATA },
            };

            private string _value;

            public TrackerTypeEnum()
            {

            }

            public TrackerTypeEnum(string value)
            {
                _value = value;
            }

            public static TrackerTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TrackerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TrackerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TrackerTypeEnum a, TrackerTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TrackerTypeEnum a, TrackerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标示追踪器名称。 在不传入该字段的情况下，将查询租户所有的追踪器。
        /// </summary>
        [SDKProperty("tracker_name", IsQuery = true)]
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }

        /// <summary>
        /// 标识追踪器类型。 目前支持系统追踪器有管理类追踪器（system）和数据类追踪器（data）。
        /// </summary>
        [SDKProperty("tracker_type", IsQuery = true)]
        [JsonProperty("tracker_type", NullValueHandling = NullValueHandling.Ignore)]
        public TrackerTypeEnum TrackerType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTrackersRequest {\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  trackerType: ").Append(TrackerType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTrackersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTrackersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackerName == input.TrackerName ||
                    (this.TrackerName != null &&
                    this.TrackerName.Equals(input.TrackerName))
                ) && 
                (
                    this.TrackerType == input.TrackerType ||
                    (this.TrackerType != null &&
                    this.TrackerType.Equals(input.TrackerType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TrackerName != null)
                    hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                if (this.TrackerType != null)
                    hashCode = hashCode * 59 + this.TrackerType.GetHashCode();
                return hashCode;
            }
        }
    }
}
