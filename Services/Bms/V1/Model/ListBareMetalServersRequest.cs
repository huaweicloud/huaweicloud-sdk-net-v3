using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListBareMetalServersRequest 
    {

        /// <summary>
        /// 裸金属服务器规格ID
        /// </summary>
        [SDKProperty("flavor", IsQuery = true)]
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 裸金属服务器名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 裸金属服务器状态,只有管理员可以使用DELETED状态过滤查询已经删除的裸金属服务器。取值范围：ACTIVE、BUILD、DELETED、ERROR、HARD_REBOOT、REBOOT、REBUILD、SHUTOFF
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 每页返回裸金属服务器的条数，默认值是25，最大值为1000。limit为每页返回裸金属服务器详情的条数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 此接口为分页查询接口:不传offset参数，返回结果是符合条件的裸金属服务器总条数,servers列表为空。传offset参数，offset为查询页码，起始页码为1，每页查询的条数为limit值。此接口为分页查询接口，offset为查询页码（起始页码为1），返回值包括总条数和裸金属详情列表传入offset：按limit值分页（limit默认为1000），返回第offset页裸金属服务器详情列表和总条数，总条数最大值为limit，不足按实际情况返回。不传入offset传入limit ：返回裸金属服务器详情列表和总条数，总条数最大值为limit，不足按实际情况返回。。不传入limit：按25条分页，返回第1页裸金属服务器详情列表，总条数最大值为25，不足按实际情况返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 裸金属服务器标签：__type_baremetal
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 批量创建裸金属服务器时，指定返回的ID，用于查询本次批量创建的裸金属服务器
        /// </summary>
        [SDKProperty("reservation_id", IsQuery = true)]
        [JsonProperty("reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReservationId { get; set; }

        /// <summary>
        /// 查询裸金属服务器结果的详细级别，级别越高，查询到的裸金属服务器信息越多，默认为4。可使用的级别为 1，2，3，4，5
        /// </summary>
        [SDKProperty("detail", IsQuery = true)]
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <summary>
        /// 查询绑定某个企业项目的裸金属服务器
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBareMetalServersRequest {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  reservationId: ").Append(ReservationId).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBareMetalServersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBareMetalServersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.ReservationId == input.ReservationId ||
                    (this.ReservationId != null &&
                    this.ReservationId.Equals(input.ReservationId))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ReservationId != null)
                    hashCode = hashCode * 59 + this.ReservationId.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
