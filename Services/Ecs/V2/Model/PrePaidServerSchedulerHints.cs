using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrePaidServerSchedulerHints 
    {
        /// <summary>
        /// 在指定的专属主机或者共享主机上创建弹性云服务器。参数值为shared或者dedicated。
        /// </summary>
        /// <value>在指定的专属主机或者共享主机上创建弹性云服务器。参数值为shared或者dedicated。</value>
        [JsonConverter(typeof(EnumClassConverter<TenancyEnum>))]
        public class TenancyEnum
        {
            /// <summary>
            /// Enum SHARED for value: shared
            /// </summary>
            public static readonly TenancyEnum SHARED = new TenancyEnum("shared");

            /// <summary>
            /// Enum DEDICATED for value: dedicated
            /// </summary>
            public static readonly TenancyEnum DEDICATED = new TenancyEnum("dedicated");

            private static readonly Dictionary<string, TenancyEnum> StaticFields =
            new Dictionary<string, TenancyEnum>()
            {
                { "shared", SHARED },
                { "dedicated", DEDICATED },
            };

            private string _value;

            public TenancyEnum()
            {

            }

            public TenancyEnum(string value)
            {
                _value = value;
            }

            public static TenancyEnum FromValue(string value)
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

                if (this.Equals(obj as TenancyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TenancyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TenancyEnum a, TenancyEnum b)
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

            public static bool operator !=(TenancyEnum a, TenancyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器组ID，UUID格式。  云服务器组的ID可以从控制台或者参考[查询云服务器组列表](https://support.huaweicloud.com/api-ecs/ecs_03_1402.html)获取。
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// 在指定的专属主机或者共享主机上创建弹性云服务器。参数值为shared或者dedicated。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public TenancyEnum Tenancy { get; set; }
        /// <summary>
        /// 专属主机的ID。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePaidServerSchedulerHints {\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrePaidServerSchedulerHints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrePaidServerSchedulerHints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Tenancy == input.Tenancy ||
                    (this.Tenancy != null &&
                    this.Tenancy.Equals(input.Tenancy))
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    (this.DedicatedHostId != null &&
                    this.DedicatedHostId.Equals(input.DedicatedHostId))
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Tenancy != null)
                    hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
