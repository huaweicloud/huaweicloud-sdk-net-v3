using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFacialAnimationsDataResponse : SdkResponse
    {
        /// <summary>
        /// 任务的状态。 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败
        /// </summary>
        /// <value>任务的状态。 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly StateEnum PROCESSING = new StateEnum("PROCESSING");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly StateEnum SUCCEED = new StateEnum("SUCCEED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("FAILED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// csv文件下载地址
        /// </summary>
        [JsonProperty("csv_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CsvFileDownloadUrl { get; set; }

        /// <summary>
        /// 任务的状态。 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 失败任务描述
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFacialAnimationsDataResponse {\n");
            sb.Append("  csvFileDownloadUrl: ").Append(CsvFileDownloadUrl).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFacialAnimationsDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFacialAnimationsDataResponse input)
        {
            if (input == null) return false;
            if (this.CsvFileDownloadUrl != input.CsvFileDownloadUrl || (this.CsvFileDownloadUrl != null && !this.CsvFileDownloadUrl.Equals(input.CsvFileDownloadUrl))) return false;
            if (this.State != input.State) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;

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
                if (this.CsvFileDownloadUrl != null) hashCode = hashCode * 59 + this.CsvFileDownloadUrl.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
