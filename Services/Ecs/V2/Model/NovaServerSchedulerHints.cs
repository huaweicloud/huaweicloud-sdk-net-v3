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
    public class NovaServerSchedulerHints 
    {
        /// <summary>
        /// Defines tenancy
        /// </summary>
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
        /// 在指定的专属主机或者共享主机上创建弹性云服务器。 参数值为shared或者dedicated。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public List<TenancyEnum> Tenancy { get; set; }
        /// <summary>
        /// 专属主机ID。 此属性仅在tenancy值为dedicated时有效。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DedicatedHostId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaServerSchedulerHints {\n");
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
            return this.Equals(input as NovaServerSchedulerHints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaServerSchedulerHints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tenancy == input.Tenancy ||
                    this.Tenancy != null &&
                    input.Tenancy != null &&
                    this.Tenancy.SequenceEqual(input.Tenancy)
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    this.DedicatedHostId != null &&
                    input.DedicatedHostId != null &&
                    this.DedicatedHostId.SequenceEqual(input.DedicatedHostId)
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
                if (this.Tenancy != null)
                    hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
