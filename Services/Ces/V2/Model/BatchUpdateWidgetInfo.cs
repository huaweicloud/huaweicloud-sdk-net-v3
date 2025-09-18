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
    /// 批量更新监控视图结果
    /// </summary>
    public class BatchUpdateWidgetInfo 
    {
        /// <summary>
        /// 修改结果；成功: successful, 失败: error 
        /// </summary>
        /// <value>修改结果；成功: successful, 失败: error </value>
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

            public static bool operator !=(RetStatusEnum a, RetStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 视图id
        /// </summary>
        [JsonProperty("widget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WidgetId { get; set; }

        /// <summary>
        /// 修改结果；成功: successful, 失败: error 
        /// </summary>
        [JsonProperty("ret_status", NullValueHandling = NullValueHandling.Ignore)]
        public RetStatusEnum RetStatus { get; set; }
        /// <summary>
        /// 如果失败则返回失败信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateWidgetInfo {\n");
            sb.Append("  widgetId: ").Append(WidgetId).Append("\n");
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
            return this.Equals(input as BatchUpdateWidgetInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateWidgetInfo input)
        {
            if (input == null) return false;
            if (this.WidgetId != input.WidgetId || (this.WidgetId != null && !this.WidgetId.Equals(input.WidgetId))) return false;
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
                if (this.WidgetId != null) hashCode = hashCode * 59 + this.WidgetId.GetHashCode();
                hashCode = hashCode * 59 + this.RetStatus.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
