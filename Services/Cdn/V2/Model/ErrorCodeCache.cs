using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// CDN状态码缓存时间
    /// </summary>
    public class ErrorCodeCache 
    {
        /// <summary>
        /// 允许配置的错误码: 400, 403, 404, 405, 414, 500, 501, 502, 503, 504
        /// </summary>
        /// <value>允许配置的错误码: 400, 403, 404, 405, 414, 500, 501, 502, 503, 504</value>
        [JsonConverter(typeof(EnumClassConverter<CodeEnum>))]
        public class CodeEnum
        {
            /// <summary>
            /// Enum NUMBER_400 for value: 400
            /// </summary>
            public static readonly CodeEnum NUMBER_400 = new CodeEnum(400);

            /// <summary>
            /// Enum NUMBER_403 for value: 403
            /// </summary>
            public static readonly CodeEnum NUMBER_403 = new CodeEnum(403);

            /// <summary>
            /// Enum NUMBER_404 for value: 404
            /// </summary>
            public static readonly CodeEnum NUMBER_404 = new CodeEnum(404);

            /// <summary>
            /// Enum NUMBER_405 for value: 405
            /// </summary>
            public static readonly CodeEnum NUMBER_405 = new CodeEnum(405);

            /// <summary>
            /// Enum NUMBER_414 for value: 414
            /// </summary>
            public static readonly CodeEnum NUMBER_414 = new CodeEnum(414);

            /// <summary>
            /// Enum NUMBER_500 for value: 500
            /// </summary>
            public static readonly CodeEnum NUMBER_500 = new CodeEnum(500);

            /// <summary>
            /// Enum NUMBER_501 for value: 501
            /// </summary>
            public static readonly CodeEnum NUMBER_501 = new CodeEnum(501);

            /// <summary>
            /// Enum NUMBER_502 for value: 502
            /// </summary>
            public static readonly CodeEnum NUMBER_502 = new CodeEnum(502);

            /// <summary>
            /// Enum NUMBER_503 for value: 503
            /// </summary>
            public static readonly CodeEnum NUMBER_503 = new CodeEnum(503);

            /// <summary>
            /// Enum NUMBER_504 for value: 504
            /// </summary>
            public static readonly CodeEnum NUMBER_504 = new CodeEnum(504);

            private static readonly Dictionary<int?, CodeEnum> StaticFields =
            new Dictionary<int?, CodeEnum>()
            {
                { 400, NUMBER_400 },
                { 403, NUMBER_403 },
                { 404, NUMBER_404 },
                { 405, NUMBER_405 },
                { 414, NUMBER_414 },
                { 500, NUMBER_500 },
                { 501, NUMBER_501 },
                { 502, NUMBER_502 },
                { 503, NUMBER_503 },
                { 504, NUMBER_504 },
            };

            private int? _value;

            public CodeEnum()
            {

            }

            public CodeEnum(int? value)
            {
                _value = value;
            }

            public static CodeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as CodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CodeEnum a, CodeEnum b)
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

            public static bool operator !=(CodeEnum a, CodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 允许配置的错误码: 400, 403, 404, 405, 414, 500, 501, 502, 503, 504
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// 错误码缓存时间，单位为秒，范围0-31,536,000(一年默认为365天)
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorCodeCache {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorCodeCache);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ErrorCodeCache input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Ttl != null)
                    hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                return hashCode;
            }
        }
    }
}
