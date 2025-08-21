using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowOutputInfoRequest 
    {
        /// <summary>
        /// true
        /// </summary>
        /// <value>true</value>
        [JsonConverter(typeof(EnumClassConverter<DataDisplayEnum>))]
        public class DataDisplayEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DataDisplayEnum TRUE = new DataDisplayEnum("true");

            private static readonly Dictionary<string, DataDisplayEnum> StaticFields =
            new Dictionary<string, DataDisplayEnum>()
            {
                { "true", TRUE },
            };

            private string _value;

            public DataDisplayEnum()
            {

            }

            public DataDisplayEnum(string value)
            {
                _value = value;
            }

            public static DataDisplayEnum FromValue(string value)
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

                if (this.Equals(obj as DataDisplayEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DataDisplayEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DataDisplayEnum a, DataDisplayEnum b)
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

            public static bool operator !=(DataDisplayEnum a, DataDisplayEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// true
        /// </summary>
        [SDKProperty("data_display", IsQuery = true)]
        [JsonProperty("data_display", NullValueHandling = NullValueHandling.Ignore)]
        public DataDisplayEnum DataDisplay { get; set; }
        /// <summary>
        /// 流id
        /// </summary>
        [SDKProperty("flow_id", IsQuery = true)]
        [JsonProperty("flow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowId { get; set; }

        /// <summary>
        /// 输出名称
        /// </summary>
        [SDKProperty("output_name", IsQuery = true)]
        [JsonProperty("output_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOutputInfoRequest {\n");
            sb.Append("  dataDisplay: ").Append(DataDisplay).Append("\n");
            sb.Append("  flowId: ").Append(FlowId).Append("\n");
            sb.Append("  outputName: ").Append(OutputName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOutputInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOutputInfoRequest input)
        {
            if (input == null) return false;
            if (this.DataDisplay != input.DataDisplay) return false;
            if (this.FlowId != input.FlowId || (this.FlowId != null && !this.FlowId.Equals(input.FlowId))) return false;
            if (this.OutputName != input.OutputName || (this.OutputName != null && !this.OutputName.Equals(input.OutputName))) return false;

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
                hashCode = hashCode * 59 + this.DataDisplay.GetHashCode();
                if (this.FlowId != null) hashCode = hashCode * 59 + this.FlowId.GetHashCode();
                if (this.OutputName != null) hashCode = hashCode * 59 + this.OutputName.GetHashCode();
                return hashCode;
            }
        }
    }
}
