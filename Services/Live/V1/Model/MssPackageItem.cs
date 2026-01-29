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
    /// MSS频道出流信息
    /// </summary>
    public class MssPackageItem 
    {

        /// <summary>
        /// package唯一标识id，由服务创建并在查询时返回，修改endpoints时需要携带。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 客户自定义的拉流地址，包括方法、域名、路径
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 从全量流中过滤出一个码率在[min, max]区间的流。如果不需要码率过滤可不选。
        /// </summary>
        [JsonProperty("stream_selection", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamSelectionItem> StreamSelection { get; set; }

        /// <summary>
        /// 频道输出分片的时长，为必选项  单位：秒。取值范围：1-10 &gt; 修改分片时长会影响已录制内容的时移和回看服务，请谨慎修改！
        /// </summary>
        [JsonProperty("segment_duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentDurationSeconds { get; set; }

        /// <summary>
        /// 频道直播返回分片的窗口长度，为频道输出分片的时长乘以数量后得到的值。实际返回的分片数不小于3个。  单位：秒。取值范围：0 - 86400（24小时转化成秒后的取值）
        /// </summary>
        [JsonProperty("playlist_window_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlaylistWindowSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// 其他额外参数
        /// </summary>
        [JsonProperty("ext_args", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExtArgs { get; set; }

        /// <summary>
        /// 延播时长，单位秒
        /// </summary>
        [JsonProperty("delay_segment", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelaySegment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_args", NullValueHandling = NullValueHandling.Ignore)]
        public PackageRequestArgs RequestArgs { get; set; }

        /// <summary>
        /// 当频道mode是ONLY_OS类型时，允许本输出可以直接从源站拉流，默认：false true：允许output访问 false：禁止output访问
        /// </summary>
        [JsonProperty("enable_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAccess { get; set; }

        /// <summary>
        /// 是否放通所有的IP访问，默认：false true：允许所有的IP地址访问，ip_whitelist配置不生效 false：不允许所有的IP地址访问，ip_whitelist生效，仅在ip_whitelist配置的ip地址才能访问
        /// </summary>
        [JsonProperty("allow_all_ip_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAllIpAccess { get; set; }

        /// <summary>
        /// 当频道类型mode是ONLY_OS类型时，允许直接从源站拉流的IP白名单
        /// </summary>
        [JsonProperty("ip_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cdn_identifier_header", NullValueHandling = NullValueHandling.Ignore)]
        public HttpHeader CdnIdentifierHeader { get; set; }

        /// <summary>
        /// 源站分发域名-主region 跟CreateOttChannelInfoReq.region一致 满足正则：^(\\[a-zA-Z0-9]([a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9])?\\.){2,}[a-zA-Z]{2,16}$ 最大长度255
        /// </summary>
        [JsonProperty("origin_domain_master", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginDomainMaster { get; set; }

        /// <summary>
        /// 源站分发域名-备region 满足正则：^(\\[a-zA-Z0-9]([a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9])?\\.){2,}[a-zA-Z]{2,16}$ 最大长度255
        /// </summary>
        [JsonProperty("origin_domain_slave", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginDomainSlave { get; set; }

        /// <summary>
        /// output的索引文件名字 默认：index 长度：0-128 字符集：大小写字母、数字、\&quot;-\&quot;、\&quot;.\&quot;、\&quot;_\&quot;，不能有/路径
        /// </summary>
        [JsonProperty("manifest_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestName { get; set; }

        /// <summary>
        /// 客户自定义的拉流地址，包括方法、域名、路径
        /// </summary>
        [JsonProperty("slave_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("manifest_selection", NullValueHandling = NullValueHandling.Ignore)]
        public ManifestSelection ManifestSelection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MssPackageItem {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  streamSelection: ").Append(StreamSelection).Append("\n");
            sb.Append("  segmentDurationSeconds: ").Append(SegmentDurationSeconds).Append("\n");
            sb.Append("  playlistWindowSeconds: ").Append(PlaylistWindowSeconds).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("  extArgs: ").Append(ExtArgs).Append("\n");
            sb.Append("  delaySegment: ").Append(DelaySegment).Append("\n");
            sb.Append("  requestArgs: ").Append(RequestArgs).Append("\n");
            sb.Append("  enableAccess: ").Append(EnableAccess).Append("\n");
            sb.Append("  allowAllIpAccess: ").Append(AllowAllIpAccess).Append("\n");
            sb.Append("  ipWhitelist: ").Append(IpWhitelist).Append("\n");
            sb.Append("  cdnIdentifierHeader: ").Append(CdnIdentifierHeader).Append("\n");
            sb.Append("  originDomainMaster: ").Append(OriginDomainMaster).Append("\n");
            sb.Append("  originDomainSlave: ").Append(OriginDomainSlave).Append("\n");
            sb.Append("  manifestName: ").Append(ManifestName).Append("\n");
            sb.Append("  slaveUrl: ").Append(SlaveUrl).Append("\n");
            sb.Append("  manifestSelection: ").Append(ManifestSelection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MssPackageItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MssPackageItem input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.StreamSelection != input.StreamSelection || (this.StreamSelection != null && input.StreamSelection != null && !this.StreamSelection.SequenceEqual(input.StreamSelection))) return false;
            if (this.SegmentDurationSeconds != input.SegmentDurationSeconds || (this.SegmentDurationSeconds != null && !this.SegmentDurationSeconds.Equals(input.SegmentDurationSeconds))) return false;
            if (this.PlaylistWindowSeconds != input.PlaylistWindowSeconds || (this.PlaylistWindowSeconds != null && !this.PlaylistWindowSeconds.Equals(input.PlaylistWindowSeconds))) return false;
            if (this.Encryption != input.Encryption || (this.Encryption != null && !this.Encryption.Equals(input.Encryption))) return false;
            if (this.ExtArgs != input.ExtArgs || (this.ExtArgs != null && !this.ExtArgs.Equals(input.ExtArgs))) return false;
            if (this.DelaySegment != input.DelaySegment || (this.DelaySegment != null && !this.DelaySegment.Equals(input.DelaySegment))) return false;
            if (this.RequestArgs != input.RequestArgs || (this.RequestArgs != null && !this.RequestArgs.Equals(input.RequestArgs))) return false;
            if (this.EnableAccess != input.EnableAccess || (this.EnableAccess != null && !this.EnableAccess.Equals(input.EnableAccess))) return false;
            if (this.AllowAllIpAccess != input.AllowAllIpAccess || (this.AllowAllIpAccess != null && !this.AllowAllIpAccess.Equals(input.AllowAllIpAccess))) return false;
            if (this.IpWhitelist != input.IpWhitelist || (this.IpWhitelist != null && !this.IpWhitelist.Equals(input.IpWhitelist))) return false;
            if (this.CdnIdentifierHeader != input.CdnIdentifierHeader || (this.CdnIdentifierHeader != null && !this.CdnIdentifierHeader.Equals(input.CdnIdentifierHeader))) return false;
            if (this.OriginDomainMaster != input.OriginDomainMaster || (this.OriginDomainMaster != null && !this.OriginDomainMaster.Equals(input.OriginDomainMaster))) return false;
            if (this.OriginDomainSlave != input.OriginDomainSlave || (this.OriginDomainSlave != null && !this.OriginDomainSlave.Equals(input.OriginDomainSlave))) return false;
            if (this.ManifestName != input.ManifestName || (this.ManifestName != null && !this.ManifestName.Equals(input.ManifestName))) return false;
            if (this.SlaveUrl != input.SlaveUrl || (this.SlaveUrl != null && !this.SlaveUrl.Equals(input.SlaveUrl))) return false;
            if (this.ManifestSelection != input.ManifestSelection || (this.ManifestSelection != null && !this.ManifestSelection.Equals(input.ManifestSelection))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.StreamSelection != null) hashCode = hashCode * 59 + this.StreamSelection.GetHashCode();
                if (this.SegmentDurationSeconds != null) hashCode = hashCode * 59 + this.SegmentDurationSeconds.GetHashCode();
                if (this.PlaylistWindowSeconds != null) hashCode = hashCode * 59 + this.PlaylistWindowSeconds.GetHashCode();
                if (this.Encryption != null) hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.ExtArgs != null) hashCode = hashCode * 59 + this.ExtArgs.GetHashCode();
                if (this.DelaySegment != null) hashCode = hashCode * 59 + this.DelaySegment.GetHashCode();
                if (this.RequestArgs != null) hashCode = hashCode * 59 + this.RequestArgs.GetHashCode();
                if (this.EnableAccess != null) hashCode = hashCode * 59 + this.EnableAccess.GetHashCode();
                if (this.AllowAllIpAccess != null) hashCode = hashCode * 59 + this.AllowAllIpAccess.GetHashCode();
                if (this.IpWhitelist != null) hashCode = hashCode * 59 + this.IpWhitelist.GetHashCode();
                if (this.CdnIdentifierHeader != null) hashCode = hashCode * 59 + this.CdnIdentifierHeader.GetHashCode();
                if (this.OriginDomainMaster != null) hashCode = hashCode * 59 + this.OriginDomainMaster.GetHashCode();
                if (this.OriginDomainSlave != null) hashCode = hashCode * 59 + this.OriginDomainSlave.GetHashCode();
                if (this.ManifestName != null) hashCode = hashCode * 59 + this.ManifestName.GetHashCode();
                if (this.SlaveUrl != null) hashCode = hashCode * 59 + this.SlaveUrl.GetHashCode();
                if (this.ManifestSelection != null) hashCode = hashCode * 59 + this.ManifestSelection.GetHashCode();
                return hashCode;
            }
        }
    }
}
