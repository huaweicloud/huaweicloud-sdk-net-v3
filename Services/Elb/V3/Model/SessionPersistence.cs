using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 参数解释：会话持久性对象。
    /// </summary>
    public class SessionPersistence 
    {

        /// <summary>
        /// 参数解释：cookie名称。  约束限制： - 只有当type为APP_COOKIE时才有效。其他情况下传该字段会报错。  [取值范围： - 共享型LB，支持字母、数字、中划线(-)和下划线(_)，最大长度64个字符。 - 独享型LB，支持字母、数字、中划线(-)、下划线(_)和点号(.)，最大长度255个字符。](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt,hk_tm) [取值范围：支持字母、数字、中划线(-)、下划线(_)和点号(.)，最大长度255个字符。](tag:hws_eu,hcso_dt)  [不支持该字段，请勿使用。](tag:hws_eu,hcso_dt)
        /// </summary>
        [JsonProperty("cookie_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CookieName { get; set; }

        /// <summary>
        /// 参数解释：会话保持类型。  [约束限制： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。如果是独享型负载均衡器的pool，则type只能为HTTP_COOKIE，其他取值会话保持失效。如果是共享型负载均衡器的pool，则type可以为HTTP_COOKIE和APP_COOKIE，其他取值会话保持失效。 - 若pool的protocol为QUIC，则必须开启session_persistence且type为SOURCE_IP。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [约束限制： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type只能为HTTP_COOKIE，其他取值会话保持失效。](tag:hws_eu,hcso_dt)  取值范围：SOURCE_IP、HTTP_COOKIE、APP_COOKIE。  [荷兰region不支持QUIC。](tag:dt) [不支持QUIC。](tag:tm)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 参数解释：会话保持的时间。当type为APP_COOKIE时不生效。  取值范围： - 若pool的protocol为TCP、UDP和QUIC则范围为[1,60]（分钟），默认值1； - 若pool的protocol为HTTP和HTTPS则范围为[1,1440]（分钟），默认值1440。  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        [JsonProperty("persistence_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? PersistenceTimeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionPersistence {\n");
            sb.Append("  cookieName: ").Append(CookieName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  persistenceTimeout: ").Append(PersistenceTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionPersistence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionPersistence input)
        {
            if (input == null) return false;
            if (this.CookieName != input.CookieName || (this.CookieName != null && !this.CookieName.Equals(input.CookieName))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.PersistenceTimeout != input.PersistenceTimeout || (this.PersistenceTimeout != null && !this.PersistenceTimeout.Equals(input.PersistenceTimeout))) return false;

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
                if (this.CookieName != null) hashCode = hashCode * 59 + this.CookieName.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PersistenceTimeout != null) hashCode = hashCode * 59 + this.PersistenceTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
