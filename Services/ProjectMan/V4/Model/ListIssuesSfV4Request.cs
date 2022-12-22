using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListIssuesSfV4Request 
    {
        /// <summary>
        /// 工作项类型
        /// </summary>
        /// <value>工作项类型</value>
        [JsonConverter(typeof(EnumClassConverter<TrackerIdEnum>))]
        public class TrackerIdEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly TrackerIdEnum NUMBER_2 = new TrackerIdEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly TrackerIdEnum NUMBER_3 = new TrackerIdEnum(3);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly TrackerIdEnum NUMBER_4 = new TrackerIdEnum(4);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly TrackerIdEnum NUMBER_5 = new TrackerIdEnum(5);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly TrackerIdEnum NUMBER_6 = new TrackerIdEnum(6);

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            public static readonly TrackerIdEnum NUMBER_7 = new TrackerIdEnum(7);

            private static readonly Dictionary<int?, TrackerIdEnum> StaticFields =
            new Dictionary<int?, TrackerIdEnum>()
            {
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
                { 4, NUMBER_4 },
                { 5, NUMBER_5 },
                { 6, NUMBER_6 },
                { 7, NUMBER_7 },
            };

            private int? _value;

            public TrackerIdEnum()
            {

            }

            public TrackerIdEnum(int? value)
            {
                _value = value;
            }

            public static TrackerIdEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as TrackerIdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TrackerIdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TrackerIdEnum a, TrackerIdEnum b)
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

            public static bool operator !=(TrackerIdEnum a, TrackerIdEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// devcloud项目的32位id
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 偏移量 从0开始
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页数量 最小1,最大100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 工作项类型
        /// </summary>
        [SDKProperty("tracker_id", IsQuery = true)]
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public TrackerIdEnum TrackerId { get; set; }
        /// <summary>
        /// 创建工作项的时间(查询的起始时间,查询的结束时间)
        /// </summary>
        [SDKProperty("created_time_interval", IsQuery = true)]
        [JsonProperty("created_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTimeInterval { get; set; }

        /// <summary>
        /// 更新工作项的时间(查询的起始时间,查询的结束时间)
        /// </summary>
        [SDKProperty("updated_time_interval", IsQuery = true)]
        [JsonProperty("updated_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTimeInterval { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIssuesSfV4Request {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  createdTimeInterval: ").Append(CreatedTimeInterval).Append("\n");
            sb.Append("  updatedTimeInterval: ").Append(UpdatedTimeInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIssuesSfV4Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIssuesSfV4Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.TrackerId == input.TrackerId ||
                    (this.TrackerId != null &&
                    this.TrackerId.Equals(input.TrackerId))
                ) && 
                (
                    this.CreatedTimeInterval == input.CreatedTimeInterval ||
                    (this.CreatedTimeInterval != null &&
                    this.CreatedTimeInterval.Equals(input.CreatedTimeInterval))
                ) && 
                (
                    this.UpdatedTimeInterval == input.UpdatedTimeInterval ||
                    (this.UpdatedTimeInterval != null &&
                    this.UpdatedTimeInterval.Equals(input.UpdatedTimeInterval))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.TrackerId != null)
                    hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.CreatedTimeInterval != null)
                    hashCode = hashCode * 59 + this.CreatedTimeInterval.GetHashCode();
                if (this.UpdatedTimeInterval != null)
                    hashCode = hashCode * 59 + this.UpdatedTimeInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
