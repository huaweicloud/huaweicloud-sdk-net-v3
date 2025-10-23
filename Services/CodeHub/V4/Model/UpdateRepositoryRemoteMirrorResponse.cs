using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateRepositoryRemoteMirrorResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：**  分支同步。 **取值范围：** - all，同步全部分支。 - default，同步默认分支。 **约束限制：** 不涉及。
        /// </summary>
        /// <value>**参数解释：**  分支同步。 **取值范围：** - all，同步全部分支。 - default，同步默认分支。 **约束限制：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<SyncBranchTypeEnum>))]
        public class SyncBranchTypeEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly SyncBranchTypeEnum ALL = new SyncBranchTypeEnum("all");

            /// <summary>
            /// Enum DEFAULT for value: default
            /// </summary>
            public static readonly SyncBranchTypeEnum DEFAULT = new SyncBranchTypeEnum("default");

            private static readonly Dictionary<string, SyncBranchTypeEnum> StaticFields =
            new Dictionary<string, SyncBranchTypeEnum>()
            {
                { "all", ALL },
                { "default", DEFAULT },
            };

            private string _value;

            public SyncBranchTypeEnum()
            {

            }

            public SyncBranchTypeEnum(string value)
            {
                _value = value;
            }

            public static SyncBranchTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SyncBranchTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SyncBranchTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SyncBranchTypeEnum a, SyncBranchTypeEnum b)
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

            public static bool operator !=(SyncBranchTypeEnum a, SyncBranchTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：**  源仓地址。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释：**  开启定时同步 **取值范围：** - true，不开启定时同步。 - false，开启定时同步。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("mirroring_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MirroringEnabled { get; set; }

        /// <summary>
        /// **参数解释：**  拓展点UUID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("endpoint_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUuid { get; set; }

        /// <summary>
        /// **参数解释：**  分支同步。 **取值范围：** - all，同步全部分支。 - default，同步默认分支。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("sync_branch_type", NullValueHandling = NullValueHandling.Ignore)]
        public SyncBranchTypeEnum SyncBranchType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepositoryRemoteMirrorResponse {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  mirroringEnabled: ").Append(MirroringEnabled).Append("\n");
            sb.Append("  endpointUuid: ").Append(EndpointUuid).Append("\n");
            sb.Append("  syncBranchType: ").Append(SyncBranchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRepositoryRemoteMirrorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRepositoryRemoteMirrorResponse input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.MirroringEnabled != input.MirroringEnabled || (this.MirroringEnabled != null && !this.MirroringEnabled.Equals(input.MirroringEnabled))) return false;
            if (this.EndpointUuid != input.EndpointUuid || (this.EndpointUuid != null && !this.EndpointUuid.Equals(input.EndpointUuid))) return false;
            if (this.SyncBranchType != input.SyncBranchType) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.MirroringEnabled != null) hashCode = hashCode * 59 + this.MirroringEnabled.GetHashCode();
                if (this.EndpointUuid != null) hashCode = hashCode * 59 + this.EndpointUuid.GetHashCode();
                hashCode = hashCode * 59 + this.SyncBranchType.GetHashCode();
                return hashCode;
            }
        }
    }
}
