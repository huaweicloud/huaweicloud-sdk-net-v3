using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTransfersRequest 
    {
        /// <summary>
        /// 日志转储类型。OBS指OBS日志转储，DIS指DIS日志转储，DMS指DMS日志转储
        /// </summary>
        /// <value>日志转储类型。OBS指OBS日志转储，DIS指DIS日志转储，DMS指DMS日志转储</value>
        [JsonConverter(typeof(EnumClassConverter<LogTransferTypeEnum>))]
        public class LogTransferTypeEnum
        {
            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly LogTransferTypeEnum OBS = new LogTransferTypeEnum("OBS");

            /// <summary>
            /// Enum DIS for value: DIS
            /// </summary>
            public static readonly LogTransferTypeEnum DIS = new LogTransferTypeEnum("DIS");

            /// <summary>
            /// Enum DMS for value: DMS
            /// </summary>
            public static readonly LogTransferTypeEnum DMS = new LogTransferTypeEnum("DMS");

            private static readonly Dictionary<string, LogTransferTypeEnum> StaticFields =
            new Dictionary<string, LogTransferTypeEnum>()
            {
                { "OBS", OBS },
                { "DIS", DIS },
                { "DMS", DMS },
            };

            private string _value;

            public LogTransferTypeEnum()
            {

            }

            public LogTransferTypeEnum(string value)
            {
                _value = value;
            }

            public static LogTransferTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LogTransferTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTransferTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTransferTypeEnum a, LogTransferTypeEnum b)
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

            public static bool operator !=(LogTransferTypeEnum a, LogTransferTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 日志转储类型。OBS指OBS日志转储，DIS指DIS日志转储，DMS指DMS日志转储
        /// </summary>
        [SDKProperty("log_transfer_type", IsQuery = true)]
        [JsonProperty("log_transfer_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTransferTypeEnum LogTransferType { get; set; }
        /// <summary>
        /// 日志组名称
        /// </summary>
        [SDKProperty("log_group_name", IsQuery = true)]
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [SDKProperty("log_stream_name", IsQuery = true)]
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransfersRequest {\n");
            sb.Append("  logTransferType: ").Append(LogTransferType).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTransfersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTransfersRequest input)
        {
            if (input == null) return false;
            if (this.LogTransferType != input.LogTransferType) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;

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
                hashCode = hashCode * 59 + this.LogTransferType.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}
