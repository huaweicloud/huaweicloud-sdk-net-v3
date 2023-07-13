using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OutputPolicy 
    {
        /// <summary>
        /// 输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 
        /// </summary>
        /// <value>输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 </value>
        [JsonConverter(typeof(EnumClassConverter<OutputPolicyEnum>))]
        public class OutputPolicyEnum
        {
            /// <summary>
            /// Enum TRANSCODE for value: transcode
            /// </summary>
            public static readonly OutputPolicyEnum TRANSCODE = new OutputPolicyEnum("transcode");

            /// <summary>
            /// Enum DISCARD for value: discard
            /// </summary>
            public static readonly OutputPolicyEnum DISCARD = new OutputPolicyEnum("discard");

            /// <summary>
            /// Enum COPY for value: copy
            /// </summary>
            public static readonly OutputPolicyEnum COPY = new OutputPolicyEnum("copy");

            private static readonly Dictionary<string, OutputPolicyEnum> StaticFields =
            new Dictionary<string, OutputPolicyEnum>()
            {
                { "transcode", TRANSCODE },
                { "discard", DISCARD },
                { "copy", COPY },
            };

            private string _value;

            public OutputPolicyEnum()
            {

            }

            public OutputPolicyEnum(string value)
            {
                _value = value;
            }

            public static OutputPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as OutputPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutputPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OutputPolicyEnum a, OutputPolicyEnum b)
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

            public static bool operator !=(OutputPolicyEnum a, OutputPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 
        /// </summary>
        [JsonProperty("output_policy", NullValueHandling = NullValueHandling.Ignore)]
        public OutputPolicyEnum _OutputPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputPolicy {\n");
            sb.Append("  _outputPolicy: ").Append(_OutputPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._OutputPolicy == input._OutputPolicy ||
                    (this._OutputPolicy != null &&
                    this._OutputPolicy.Equals(input._OutputPolicy))
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
                if (this._OutputPolicy != null)
                    hashCode = hashCode * 59 + this._OutputPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
