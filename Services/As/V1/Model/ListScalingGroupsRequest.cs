using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListScalingGroupsRequest 
    {
        /// <summary>
        /// Defines scalingGroupStatus
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ScalingGroupStatusEnum>))]
        public class ScalingGroupStatusEnum
        {
            /// <summary>
            /// Enum INSERVICE for value: INSERVICE
            /// </summary>
            public static readonly ScalingGroupStatusEnum INSERVICE = new ScalingGroupStatusEnum("INSERVICE");

            /// <summary>
            /// Enum PAUSED for value: PAUSED
            /// </summary>
            public static readonly ScalingGroupStatusEnum PAUSED = new ScalingGroupStatusEnum("PAUSED");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly ScalingGroupStatusEnum ERROR = new ScalingGroupStatusEnum("ERROR");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly ScalingGroupStatusEnum DELETING = new ScalingGroupStatusEnum("DELETING");

            private static readonly Dictionary<string, ScalingGroupStatusEnum> StaticFields =
            new Dictionary<string, ScalingGroupStatusEnum>()
            {
                { "INSERVICE", INSERVICE },
                { "PAUSED", PAUSED },
                { "ERROR", ERROR },
                { "DELETING", DELETING },
            };

            private string Value;

            public ScalingGroupStatusEnum(string value)
            {
                Value = value;
            }

            public static ScalingGroupStatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ScalingGroupStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingGroupStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ScalingGroupStatusEnum a, ScalingGroupStatusEnum b)
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

            public static bool operator !=(ScalingGroupStatusEnum a, ScalingGroupStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("scaling_group_name", IsQuery = true)]
        [JsonProperty("scaling_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("scaling_configuration_id", IsQuery = true)]
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("scaling_group_status", IsQuery = true)]
        [JsonProperty("scaling_group_status", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingGroupStatusEnum ScalingGroupStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingGroupsRequest {\n");
            sb.Append("  scalingGroupName: ").Append(ScalingGroupName).Append("\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("  scalingGroupStatus: ").Append(ScalingGroupStatus).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingGroupsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingGroupName == input.ScalingGroupName ||
                    (this.ScalingGroupName != null &&
                    this.ScalingGroupName.Equals(input.ScalingGroupName))
                ) && 
                (
                    this.ScalingConfigurationId == input.ScalingConfigurationId ||
                    (this.ScalingConfigurationId != null &&
                    this.ScalingConfigurationId.Equals(input.ScalingConfigurationId))
                ) && 
                (
                    this.ScalingGroupStatus == input.ScalingGroupStatus ||
                    (this.ScalingGroupStatus != null &&
                    this.ScalingGroupStatus.Equals(input.ScalingGroupStatus))
                ) && 
                (
                    this.StartNumber == input.StartNumber ||
                    (this.StartNumber != null &&
                    this.StartNumber.Equals(input.StartNumber))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.ScalingGroupName != null)
                    hashCode = hashCode * 59 + this.ScalingGroupName.GetHashCode();
                if (this.ScalingConfigurationId != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                if (this.ScalingGroupStatus != null)
                    hashCode = hashCode * 59 + this.ScalingGroupStatus.GetHashCode();
                if (this.StartNumber != null)
                    hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
