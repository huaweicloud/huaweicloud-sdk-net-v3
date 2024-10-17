using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteDashboardRespInfo 
    {
        /// <summary>
        /// 处理结果, successful: 成功, error: 失败
        /// </summary>
        /// <value>处理结果, successful: 成功, error: 失败</value>
        [JsonConverter(typeof(EnumClassConverter<RetStatusEnum>))]
        public class RetStatusEnum
        {
            /// <summary>
            /// Enum SUCCESSFUL for value: successful
            /// </summary>
            public static readonly RetStatusEnum SUCCESSFUL = new RetStatusEnum("successful");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly RetStatusEnum ERROR = new RetStatusEnum("error");

            private static readonly Dictionary<string, RetStatusEnum> StaticFields =
            new Dictionary<string, RetStatusEnum>()
            {
                { "successful", SUCCESSFUL },
                { "error", ERROR },
            };

            private string _value;

            public RetStatusEnum()
            {

            }

            public RetStatusEnum(string value)
            {
                _value = value;
            }

            public static RetStatusEnum FromValue(string value)
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

                if (this.Equals(obj as RetStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RetStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RetStatusEnum a, RetStatusEnum b)
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

            public static bool operator !=(RetStatusEnum a, RetStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 监控看板id
        /// </summary>
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }

        /// <summary>
        /// 处理结果, successful: 成功, error: 失败
        /// </summary>
        [JsonProperty("ret_status", NullValueHandling = NullValueHandling.Ignore)]
        public RetStatusEnum RetStatus { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteDashboardRespInfo {\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("  retStatus: ").Append(RetStatus).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteDashboardRespInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteDashboardRespInfo input)
        {
            if (input == null) return false;
            if (this.DashboardId != input.DashboardId || (this.DashboardId != null && !this.DashboardId.Equals(input.DashboardId))) return false;
            if (this.RetStatus != input.RetStatus) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;

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
                if (this.DashboardId != null) hashCode = hashCode * 59 + this.DashboardId.GetHashCode();
                hashCode = hashCode * 59 + this.RetStatus.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
