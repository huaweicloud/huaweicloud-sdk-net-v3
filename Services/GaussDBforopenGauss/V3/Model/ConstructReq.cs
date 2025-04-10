using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 搭建容灾请求参数。
    /// </summary>
    public class ConstructReq 
    {
        /// <summary>
        /// 容灾类型。
        /// </summary>
        /// <value>容灾类型。</value>
        [JsonConverter(typeof(EnumClassConverter<DisasterTypeEnum>))]
        public class DisasterTypeEnum
        {
            /// <summary>
            /// Enum STREAM for value: stream
            /// </summary>
            public static readonly DisasterTypeEnum STREAM = new DisasterTypeEnum("stream");

            /// <summary>
            /// Enum DORADO for value: dorado
            /// </summary>
            public static readonly DisasterTypeEnum DORADO = new DisasterTypeEnum("dorado");

            private static readonly Dictionary<string, DisasterTypeEnum> StaticFields =
            new Dictionary<string, DisasterTypeEnum>()
            {
                { "stream", STREAM },
                { "dorado", DORADO },
            };

            private string _value;

            public DisasterTypeEnum()
            {

            }

            public DisasterTypeEnum(string value)
            {
                _value = value;
            }

            public static DisasterTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DisasterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DisasterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DisasterTypeEnum a, DisasterTypeEnum b)
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

            public static bool operator !=(DisasterTypeEnum a, DisasterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 容灾类型。
        /// </summary>
        [JsonProperty("disaster_type", NullValueHandling = NullValueHandling.Ignore)]
        public DisasterTypeEnum DisasterType { get; set; }
        /// <summary>
        /// 对端实例任意数据ip。
        /// </summary>
        [JsonProperty("dr_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DrIp { get; set; }

        /// <summary>
        /// 对端实例账户名称。
        /// </summary>
        [JsonProperty("dr_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DrUserName { get; set; }

        /// <summary>
        /// 对端实例账户密码。
        /// </summary>
        [JsonProperty("dr_user_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DrUserPassword { get; set; }

        /// <summary>
        /// 容灾任务名称
        /// </summary>
        [JsonProperty("dr_task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DrTaskName { get; set; }

        /// <summary>
        /// 灾备实例为轻量化部署.
        /// </summary>
        [JsonProperty("lite_dr_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string LiteDrMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructReq {\n");
            sb.Append("  disasterType: ").Append(DisasterType).Append("\n");
            sb.Append("  drIp: ").Append(DrIp).Append("\n");
            sb.Append("  drUserName: ").Append(DrUserName).Append("\n");
            sb.Append("  drUserPassword: ").Append(DrUserPassword).Append("\n");
            sb.Append("  drTaskName: ").Append(DrTaskName).Append("\n");
            sb.Append("  liteDrMode: ").Append(LiteDrMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConstructReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConstructReq input)
        {
            if (input == null) return false;
            if (this.DisasterType != input.DisasterType) return false;
            if (this.DrIp != input.DrIp || (this.DrIp != null && !this.DrIp.Equals(input.DrIp))) return false;
            if (this.DrUserName != input.DrUserName || (this.DrUserName != null && !this.DrUserName.Equals(input.DrUserName))) return false;
            if (this.DrUserPassword != input.DrUserPassword || (this.DrUserPassword != null && !this.DrUserPassword.Equals(input.DrUserPassword))) return false;
            if (this.DrTaskName != input.DrTaskName || (this.DrTaskName != null && !this.DrTaskName.Equals(input.DrTaskName))) return false;
            if (this.LiteDrMode != input.LiteDrMode || (this.LiteDrMode != null && !this.LiteDrMode.Equals(input.LiteDrMode))) return false;

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
                hashCode = hashCode * 59 + this.DisasterType.GetHashCode();
                if (this.DrIp != null) hashCode = hashCode * 59 + this.DrIp.GetHashCode();
                if (this.DrUserName != null) hashCode = hashCode * 59 + this.DrUserName.GetHashCode();
                if (this.DrUserPassword != null) hashCode = hashCode * 59 + this.DrUserPassword.GetHashCode();
                if (this.DrTaskName != null) hashCode = hashCode * 59 + this.DrTaskName.GetHashCode();
                if (this.LiteDrMode != null) hashCode = hashCode * 59 + this.LiteDrMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
