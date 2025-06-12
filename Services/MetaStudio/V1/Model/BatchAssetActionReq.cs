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
    /// 批量操作请求体
    /// </summary>
    public class BatchAssetActionReq 
    {
        /// <summary>
        /// 批量操作命令. * DELETE：删除 * DELETE_FORCE：强制删除，该模式会立即删除资产 * RESTORE：恢复 * UNACTIVE：取消激活 * ACTIVE：激活 * SHARE：共享 * UNSHARE：取消共享
        /// </summary>
        /// <value>批量操作命令. * DELETE：删除 * DELETE_FORCE：强制删除，该模式会立即删除资产 * RESTORE：恢复 * UNACTIVE：取消激活 * ACTIVE：激活 * SHARE：共享 * UNSHARE：取消共享</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("DELETE");

            /// <summary>
            /// Enum DELETE_FORCE for value: DELETE_FORCE
            /// </summary>
            public static readonly ActionEnum DELETE_FORCE = new ActionEnum("DELETE_FORCE");

            /// <summary>
            /// Enum RESTORE for value: RESTORE
            /// </summary>
            public static readonly ActionEnum RESTORE = new ActionEnum("RESTORE");

            /// <summary>
            /// Enum UNACTIVE for value: UNACTIVE
            /// </summary>
            public static readonly ActionEnum UNACTIVE = new ActionEnum("UNACTIVE");

            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly ActionEnum ACTIVE = new ActionEnum("ACTIVE");

            /// <summary>
            /// Enum SHARE for value: SHARE
            /// </summary>
            public static readonly ActionEnum SHARE = new ActionEnum("SHARE");

            /// <summary>
            /// Enum UNSHARE for value: UNSHARE
            /// </summary>
            public static readonly ActionEnum UNSHARE = new ActionEnum("UNSHARE");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "DELETE", DELETE },
                { "DELETE_FORCE", DELETE_FORCE },
                { "RESTORE", RESTORE },
                { "UNACTIVE", UNACTIVE },
                { "ACTIVE", ACTIVE },
                { "SHARE", SHARE },
                { "UNSHARE", UNSHARE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 批量操作命令. * DELETE：删除 * DELETE_FORCE：强制删除，该模式会立即删除资产 * RESTORE：恢复 * UNACTIVE：取消激活 * ACTIVE：激活 * SHARE：共享 * UNSHARE：取消共享
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 资产ID列表
        /// </summary>
        [JsonProperty("asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetIds { get; set; }

        /// <summary>
        /// 操作参数
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public string Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAssetActionReq {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  assetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAssetActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAssetActionReq input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.AssetIds != input.AssetIds || (this.AssetIds != null && input.AssetIds != null && !this.AssetIds.SequenceEqual(input.AssetIds))) return false;
            if (this.Params != input.Params || (this.Params != null && !this.Params.Equals(input.Params))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AssetIds != null) hashCode = hashCode * 59 + this.AssetIds.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
