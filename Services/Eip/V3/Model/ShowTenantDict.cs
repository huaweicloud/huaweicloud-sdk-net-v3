using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowTenantDict 
    {
        /// <summary>
        /// 带宽的计费模式
        /// </summary>
        /// <value>带宽的计费模式</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum BANDWIDTH for value: bandwidth
            /// </summary>
            public static readonly ChargeModeEnum BANDWIDTH = new ChargeModeEnum("bandwidth");

            /// <summary>
            /// Enum TRAFFIC for value: traffic
            /// </summary>
            public static readonly ChargeModeEnum TRAFFIC = new ChargeModeEnum("traffic");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "bandwidth", BANDWIDTH },
                { "traffic", TRAFFIC },
            };

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
            }

            public static ChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
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

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// - 功能说明：弹性公网IP的唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 带宽的计费模式
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 该类型带宽可购买的最小size
        /// </summary>
        [JsonProperty("min_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinSize { get; set; }

        /// <summary>
        /// 该类型带宽可购买的最大size
        /// </summary>
        [JsonProperty("max_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ext_limit", NullValueHandling = NullValueHandling.Ignore)]
        public ExtLimitPojo ExtLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTenantDict {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  minSize: ").Append(MinSize).Append("\n");
            sb.Append("  maxSize: ").Append(MaxSize).Append("\n");
            sb.Append("  extLimit: ").Append(ExtLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTenantDict);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTenantDict input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.MinSize != input.MinSize || (this.MinSize != null && !this.MinSize.Equals(input.MinSize))) return false;
            if (this.MaxSize != input.MaxSize || (this.MaxSize != null && !this.MaxSize.Equals(input.MaxSize))) return false;
            if (this.ExtLimit != input.ExtLimit || (this.ExtLimit != null && !this.ExtLimit.Equals(input.ExtLimit))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.MinSize != null) hashCode = hashCode * 59 + this.MinSize.GetHashCode();
                if (this.MaxSize != null) hashCode = hashCode * 59 + this.MaxSize.GetHashCode();
                if (this.ExtLimit != null) hashCode = hashCode * 59 + this.ExtLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
