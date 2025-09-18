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
    public class DeleteScalingGroupRequest 
    {
        /// <summary>
        /// 是否强制删除伸缩组。默认为no；可选值为yes或no。
        /// </summary>
        /// <value>是否强制删除伸缩组。默认为no；可选值为yes或no。</value>
        [JsonConverter(typeof(EnumClassConverter<ForceDeleteEnum>))]
        public class ForceDeleteEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly ForceDeleteEnum YES = new ForceDeleteEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly ForceDeleteEnum NO = new ForceDeleteEnum("no");

            private static readonly Dictionary<string, ForceDeleteEnum> StaticFields =
            new Dictionary<string, ForceDeleteEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string _value;

            public ForceDeleteEnum()
            {

            }

            public ForceDeleteEnum(string value)
            {
                _value = value;
            }

            public static ForceDeleteEnum FromValue(string value)
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

                if (this.Equals(obj as ForceDeleteEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ForceDeleteEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ForceDeleteEnum a, ForceDeleteEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ForceDeleteEnum a, ForceDeleteEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [SDKProperty("scaling_group_id", IsPath = true)]
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 是否强制删除伸缩组。默认为no；可选值为yes或no。
        /// </summary>
        [SDKProperty("force_delete", IsQuery = true)]
        [JsonProperty("force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public ForceDeleteEnum ForceDelete { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteScalingGroupRequest {\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  forceDelete: ").Append(ForceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteScalingGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteScalingGroupRequest input)
        {
            if (input == null) return false;
            if (this.ScalingGroupId != input.ScalingGroupId || (this.ScalingGroupId != null && !this.ScalingGroupId.Equals(input.ScalingGroupId))) return false;
            if (this.ForceDelete != input.ForceDelete) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ScalingGroupId != null) hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
