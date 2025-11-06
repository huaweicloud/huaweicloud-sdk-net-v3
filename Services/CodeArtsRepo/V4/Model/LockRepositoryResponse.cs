using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class LockRepositoryResponse : SdkResponse
    {
        /// <summary>
        /// 锁定状态 - true 已锁定 - false 未锁定 
        /// </summary>
        /// <value>锁定状态 - true 已锁定 - false 未锁定 </value>
        [JsonConverter(typeof(EnumClassConverter<LockedEnum>))]
        public class LockedEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly LockedEnum TRUE = new LockedEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly LockedEnum FALSE = new LockedEnum("false");

            private static readonly Dictionary<string, LockedEnum> StaticFields =
            new Dictionary<string, LockedEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public LockedEnum()
            {

            }

            public LockedEnum(string value)
            {
                _value = value;
            }

            public static LockedEnum FromValue(string value)
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

                if (this.Equals(obj as LockedEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LockedEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LockedEnum a, LockedEnum b)
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

            public static bool operator !=(LockedEnum a, LockedEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 锁定状态 - true 已锁定 - false 未锁定 
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public LockedEnum Locked { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockRepositoryResponse {\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LockRepositoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LockRepositoryResponse input)
        {
            if (input == null) return false;
            if (this.Locked != input.Locked) return false;

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
                hashCode = hashCode * 59 + this.Locked.GetHashCode();
                return hashCode;
            }
        }
    }
}
