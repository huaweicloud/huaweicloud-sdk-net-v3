using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateUserDriverReq 
    {
        /// <summary>
        /// 指定待同步的驱动文件类型。取值范围： - db2：DB2 for LUW - informix：Informix
        /// </summary>
        /// <value>指定待同步的驱动文件类型。取值范围： - db2：DB2 for LUW - informix：Informix</value>
        [JsonConverter(typeof(EnumClassConverter<DriverTypeEnum>))]
        public class DriverTypeEnum
        {
            /// <summary>
            /// Enum DB2 for value: db2
            /// </summary>
            public static readonly DriverTypeEnum DB2 = new DriverTypeEnum("db2");

            /// <summary>
            /// Enum INFORMIX for value: informix
            /// </summary>
            public static readonly DriverTypeEnum INFORMIX = new DriverTypeEnum("informix");

            private static readonly Dictionary<string, DriverTypeEnum> StaticFields =
            new Dictionary<string, DriverTypeEnum>()
            {
                { "db2", DB2 },
                { "informix", INFORMIX },
            };

            private string _value;

            public DriverTypeEnum()
            {

            }

            public DriverTypeEnum(string value)
            {
                _value = value;
            }

            public static DriverTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DriverTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DriverTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DriverTypeEnum a, DriverTypeEnum b)
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

            public static bool operator !=(DriverTypeEnum a, DriverTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// JDBC驱动文件名称，name的长度5-64，结尾以.jar结尾。
        /// </summary>
        [JsonProperty("driver_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverName { get; set; }

        /// <summary>
        /// 指定待同步的驱动文件类型。取值范围： - db2：DB2 for LUW - informix：Informix
        /// </summary>
        [JsonProperty("driver_type", NullValueHandling = NullValueHandling.Ignore)]
        public DriverTypeEnum DriverType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserDriverReq {\n");
            sb.Append("  driverName: ").Append(DriverName).Append("\n");
            sb.Append("  driverType: ").Append(DriverType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserDriverReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserDriverReq input)
        {
            if (input == null) return false;
            if (this.DriverName != input.DriverName || (this.DriverName != null && !this.DriverName.Equals(input.DriverName))) return false;
            if (this.DriverType != input.DriverType) return false;

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
                if (this.DriverName != null) hashCode = hashCode * 59 + this.DriverName.GetHashCode();
                hashCode = hashCode * 59 + this.DriverType.GetHashCode();
                return hashCode;
            }
        }
    }
}
