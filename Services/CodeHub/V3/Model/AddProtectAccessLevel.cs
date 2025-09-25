using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddProtectAccessLevel 
    {
        /// <summary>
        /// 提交权限 0:任何人不允许提交，30:开发者及管理员可提交，40:管理员可提交
        /// </summary>
        /// <value>提交权限 0:任何人不允许提交，30:开发者及管理员可提交，40:管理员可提交</value>
        [JsonConverter(typeof(EnumClassConverter<PushAccessLevelEnum>))]
        public class PushAccessLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly PushAccessLevelEnum NUMBER_0 = new PushAccessLevelEnum(0);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly PushAccessLevelEnum NUMBER_30 = new PushAccessLevelEnum(30);

            /// <summary>
            /// Enum NUMBER_40 for value: 40
            /// </summary>
            public static readonly PushAccessLevelEnum NUMBER_40 = new PushAccessLevelEnum(40);

            private static readonly Dictionary<int?, PushAccessLevelEnum> StaticFields =
            new Dictionary<int?, PushAccessLevelEnum>()
            {
                { 0, NUMBER_0 },
                { 30, NUMBER_30 },
                { 40, NUMBER_40 },
            };

            private int? _value;

            public PushAccessLevelEnum()
            {

            }

            public PushAccessLevelEnum(int? value)
            {
                _value = value;
            }

            public static PushAccessLevelEnum FromValue(int? value)
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

                if (this.Equals(obj as PushAccessLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PushAccessLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PushAccessLevelEnum a, PushAccessLevelEnum b)
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

            public static bool operator !=(PushAccessLevelEnum a, PushAccessLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 合并权限 0:任何人不允许合并，30:开发者及管理员可合并，40:管理员可合并,合并权限必须大于等于提交权限
        /// </summary>
        /// <value>合并权限 0:任何人不允许合并，30:开发者及管理员可合并，40:管理员可合并,合并权限必须大于等于提交权限</value>
        [JsonConverter(typeof(EnumClassConverter<MergeAccessLevelEnum>))]
        public class MergeAccessLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly MergeAccessLevelEnum NUMBER_0 = new MergeAccessLevelEnum(0);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly MergeAccessLevelEnum NUMBER_30 = new MergeAccessLevelEnum(30);

            /// <summary>
            /// Enum NUMBER_40 for value: 40
            /// </summary>
            public static readonly MergeAccessLevelEnum NUMBER_40 = new MergeAccessLevelEnum(40);

            private static readonly Dictionary<int?, MergeAccessLevelEnum> StaticFields =
            new Dictionary<int?, MergeAccessLevelEnum>()
            {
                { 0, NUMBER_0 },
                { 30, NUMBER_30 },
                { 40, NUMBER_40 },
            };

            private int? _value;

            public MergeAccessLevelEnum()
            {

            }

            public MergeAccessLevelEnum(int? value)
            {
                _value = value;
            }

            public static MergeAccessLevelEnum FromValue(int? value)
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

                if (this.Equals(obj as MergeAccessLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MergeAccessLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MergeAccessLevelEnum a, MergeAccessLevelEnum b)
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

            public static bool operator !=(MergeAccessLevelEnum a, MergeAccessLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 提交权限 0:任何人不允许提交，30:开发者及管理员可提交，40:管理员可提交
        /// </summary>
        [JsonProperty("push_access_level", NullValueHandling = NullValueHandling.Ignore)]
        public PushAccessLevelEnum PushAccessLevel { get; set; }
        /// <summary>
        /// 合并权限 0:任何人不允许合并，30:开发者及管理员可合并，40:管理员可合并,合并权限必须大于等于提交权限
        /// </summary>
        [JsonProperty("merge_access_level", NullValueHandling = NullValueHandling.Ignore)]
        public MergeAccessLevelEnum MergeAccessLevel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddProtectAccessLevel {\n");
            sb.Append("  pushAccessLevel: ").Append(PushAccessLevel).Append("\n");
            sb.Append("  mergeAccessLevel: ").Append(MergeAccessLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddProtectAccessLevel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddProtectAccessLevel input)
        {
            if (input == null) return false;
            if (this.PushAccessLevel != input.PushAccessLevel) return false;
            if (this.MergeAccessLevel != input.MergeAccessLevel) return false;

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
                hashCode = hashCode * 59 + this.PushAccessLevel.GetHashCode();
                hashCode = hashCode * 59 + this.MergeAccessLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
