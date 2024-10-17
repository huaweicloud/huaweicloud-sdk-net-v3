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
    public class DeleteScalingInstanceRequest 
    {
        /// <summary>
        /// 实例移出伸缩组，是否删除云服务器实例。默认为no；可选值为yes或no。
        /// </summary>
        /// <value>实例移出伸缩组，是否删除云服务器实例。默认为no；可选值为yes或no。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceDeleteEnum>))]
        public class InstanceDeleteEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly InstanceDeleteEnum YES = new InstanceDeleteEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly InstanceDeleteEnum NO = new InstanceDeleteEnum("no");

            private static readonly Dictionary<string, InstanceDeleteEnum> StaticFields =
            new Dictionary<string, InstanceDeleteEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string _value;

            public InstanceDeleteEnum()
            {

            }

            public InstanceDeleteEnum(string value)
            {
                _value = value;
            }

            public static InstanceDeleteEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceDeleteEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceDeleteEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceDeleteEnum a, InstanceDeleteEnum b)
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

            public static bool operator !=(InstanceDeleteEnum a, InstanceDeleteEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID，可参考[查询弹性伸缩组中的实例列表](https://support.huaweicloud.com/api-as/as_06_0301.html)获取。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例移出伸缩组，是否删除云服务器实例。默认为no；可选值为yes或no。
        /// </summary>
        [SDKProperty("instance_delete", IsQuery = true)]
        [JsonProperty("instance_delete", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceDeleteEnum InstanceDelete { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteScalingInstanceRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceDelete: ").Append(InstanceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteScalingInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteScalingInstanceRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceDelete != input.InstanceDelete) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
