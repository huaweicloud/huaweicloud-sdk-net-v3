using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 批量修改数据库密码请求列表
    /// </summary>
    public class ModifyPwdEndPoint 
    {
        /// <summary>
        /// 类型，so：源库；ta：目标库。
        /// </summary>
        /// <value>类型，so：源库；ta：目标库。</value>
        [JsonConverter(typeof(EnumClassConverter<EndPointTypeEnum>))]
        public class EndPointTypeEnum
        {
            /// <summary>
            /// Enum SO for value: so
            /// </summary>
            public static readonly EndPointTypeEnum SO = new EndPointTypeEnum("so");

            /// <summary>
            /// Enum TA for value: ta
            /// </summary>
            public static readonly EndPointTypeEnum TA = new EndPointTypeEnum("ta");

            private static readonly Dictionary<string, EndPointTypeEnum> StaticFields =
            new Dictionary<string, EndPointTypeEnum>()
            {
                { "so", SO },
                { "ta", TA },
            };

            private string _value;

            public EndPointTypeEnum()
            {

            }

            public EndPointTypeEnum(string value)
            {
                _value = value;
            }

            public static EndPointTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EndPointTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EndPointTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EndPointTypeEnum a, EndPointTypeEnum b)
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

            public static bool operator !=(EndPointTypeEnum a, EndPointTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库密码
        /// </summary>
        [JsonProperty("db_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPassword { get; set; }

        /// <summary>
        /// 类型，so：源库；ta：目标库。
        /// </summary>
        [JsonProperty("end_point_type", NullValueHandling = NullValueHandling.Ignore)]
        public EndPointTypeEnum EndPointType { get; set; }
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kerberos", NullValueHandling = NullValueHandling.Ignore)]
        public KerberosVO Kerberos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyPwdEndPoint {\n");
            sb.Append("  dbPassword: ").Append(DbPassword).Append("\n");
            sb.Append("  endPointType: ").Append(EndPointType).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  kerberos: ").Append(Kerberos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyPwdEndPoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyPwdEndPoint input)
        {
            if (input == null) return false;
            if (this.DbPassword != input.DbPassword || (this.DbPassword != null && !this.DbPassword.Equals(input.DbPassword))) return false;
            if (this.EndPointType != input.EndPointType) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Kerberos != input.Kerberos || (this.Kerberos != null && !this.Kerberos.Equals(input.Kerberos))) return false;

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
                if (this.DbPassword != null) hashCode = hashCode * 59 + this.DbPassword.GetHashCode();
                hashCode = hashCode * 59 + this.EndPointType.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Kerberos != null) hashCode = hashCode * 59 + this.Kerberos.GetHashCode();
                return hashCode;
            }
        }
    }
}
