using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoTranslateInference 
    {
        /// <summary>
        /// 是否回写
        /// </summary>
        /// <value>是否回写</value>
        [JsonConverter(typeof(EnumClassConverter<RewriteEnum>))]
        public class RewriteEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly RewriteEnum TRUE = new RewriteEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly RewriteEnum FALSE = new RewriteEnum("false");

            private static readonly Dictionary<string, RewriteEnum> StaticFields =
            new Dictionary<string, RewriteEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public RewriteEnum()
            {

            }

            public RewriteEnum(string value)
            {
                _value = value;
            }

            public static RewriteEnum FromValue(string value)
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

                if (this.Equals(obj as RewriteEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RewriteEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RewriteEnum a, RewriteEnum b)
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

            public static bool operator !=(RewriteEnum a, RewriteEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 字幕翻译目标语言
        /// </summary>
        [JsonProperty("target_language", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// 是否回写
        /// </summary>
        [JsonProperty("rewrite", NullValueHandling = NullValueHandling.Ignore)]
        public RewriteEnum Rewrite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rewrite_config", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTranslateInferenceRewriteConfig RewriteConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoTranslateInference {\n");
            sb.Append("  targetLanguage: ").Append(TargetLanguage).Append("\n");
            sb.Append("  rewrite: ").Append(Rewrite).Append("\n");
            sb.Append("  rewriteConfig: ").Append(RewriteConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoTranslateInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoTranslateInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetLanguage == input.TargetLanguage ||
                    (this.TargetLanguage != null &&
                    this.TargetLanguage.Equals(input.TargetLanguage))
                ) && 
                (
                    this.Rewrite == input.Rewrite ||
                    (this.Rewrite != null &&
                    this.Rewrite.Equals(input.Rewrite))
                ) && 
                (
                    this.RewriteConfig == input.RewriteConfig ||
                    (this.RewriteConfig != null &&
                    this.RewriteConfig.Equals(input.RewriteConfig))
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
                if (this.TargetLanguage != null)
                    hashCode = hashCode * 59 + this.TargetLanguage.GetHashCode();
                if (this.Rewrite != null)
                    hashCode = hashCode * 59 + this.Rewrite.GetHashCode();
                if (this.RewriteConfig != null)
                    hashCode = hashCode * 59 + this.RewriteConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
