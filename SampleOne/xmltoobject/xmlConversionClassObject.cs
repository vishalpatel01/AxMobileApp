using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SampleOne.xmltoobject
{
    [XmlRoot(ElementName = "Header", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
    public class Header
    {
        [XmlElement(ElementName = "MessageId", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
        public string MessageId { get; set; }
        [XmlElement(ElementName = "Action", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
        public string Action { get; set; }
    }

    [XmlRoot(ElementName = "PriceDiscTable", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
    public class PriceDiscTable
    {
        [XmlElement(ElementName = "_DocumentHash", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string _DocumentHash { get; set; }
        [XmlElement(ElementName = "RecId", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string RecId { get; set; }
        [XmlElement(ElementName = "RecVersion", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string RecVersion { get; set; }
        [XmlElement(ElementName = "ItemCode", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string ItemCode { get; set; }
        [XmlElement(ElementName = "AccountCode", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string AccountCode { get; set; }
        [XmlElement(ElementName = "ItemRelation", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string ItemRelation { get; set; }
        [XmlElement(ElementName = "AccountRelation", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string AccountRelation { get; set; }
        [XmlElement(ElementName = "QuantityAmountFrom", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string QuantityAmountFrom { get; set; }
        [XmlElement(ElementName = "ToDate", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string ToDate { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string Amount { get; set; }
        [XmlElement(ElementName = "Currency", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string Currency { get; set; }
        [XmlElement(ElementName = "SearchAgain", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string SearchAgain { get; set; }
        [XmlElement(ElementName = "PriceUnit", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string PriceUnit { get; set; }
        [XmlElement(ElementName = "relation", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string Relation { get; set; }
        [XmlElement(ElementName = "UnitId", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string UnitId { get; set; }
        [XmlElement(ElementName = "AllocateMarkup", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string AllocateMarkup { get; set; }
        [XmlElement(ElementName = "CalendarDays", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string CalendarDays { get; set; }
        [XmlElement(ElementName = "GenericCurrency", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string GenericCurrency { get; set; }
        [XmlElement(ElementName = "DisregardLeadTime", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string DisregardLeadTime { get; set; }
        [XmlAttribute(AttributeName = "class")]
        public string Class { get; set; }
    }

    [XmlRoot(ElementName = "KSIItemPriceDiscAdm", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
    public class KSIItemPriceDiscAdm
    {
        [XmlElement(ElementName = "DocPurpose", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string DocPurpose { get; set; }
        [XmlElement(ElementName = "SenderId", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public string SenderId { get; set; }
        [XmlElement(ElementName = "PriceDiscTable", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public List<PriceDiscTable> PriceDiscTable { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "MessageParts", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
    public class MessageParts
    {
        [XmlElement(ElementName = "KSIItemPriceDiscAdm", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/KSIItemPriceDiscAdm")]
        public KSIItemPriceDiscAdm KSIItemPriceDiscAdm { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
    public class Body
    {
        [XmlElement(ElementName = "MessageParts", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
        public MessageParts MessageParts { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.microsoft.com/dynamics/2011/01/documents/Message")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

}