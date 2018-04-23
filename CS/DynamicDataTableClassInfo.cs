using System;
using System.Data;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System.Collections.Generic;

namespace DynamicDataTable {
    public class DynamicDataTableClassInfo : XPClassInfo {
        private readonly IList<XPMemberInfo> ownMembersCore = new List<XPMemberInfo>();
        private readonly string tableNameCore;
        private readonly XPClassInfo baseClassCore;
        public DynamicDataTableClassInfo(XPDictionary dictionary, DataTable table)
            : base(dictionary) {
            baseClassCore = dictionary.QueryClassInfo(typeof(XPDataTableObject));
            tableNameCore = table.TableName;
            foreach (DataColumn column in table.Columns) {
                XPCustomMemberInfo member = CreateMember(column.Caption, column.DataType);
                member.AddAttribute(new PersistentAttribute(column.ColumnName));
                member.AddAttribute(new DisplayNameAttribute(column.Caption));
                if (table.PrimaryKey.Length > 0 && table.PrimaryKey[0] == column)
                    member.AddAttribute(new KeyAttribute(column.AutoIncrement));
            }
        }
        public override string AssemblyName {
            get { return GetType().Assembly.FullName; }
        }
        public override XPClassInfo BaseClass {
            get { return baseClassCore; }
        }
        public override Type ClassType {
            get { return BaseClass.ClassType; }
        }
        protected override object CreateObjectInstance(Session session, XPClassInfo instantiationClassInfo) {
            return new XPDataTableObject(session, instantiationClassInfo);
        }
        public override string FullName {
            get { return tableNameCore; }
        }
        public override ICollection<XPMemberInfo> OwnMembers {
            get { return ownMembersCore; }
        }
        public override void AddMember(XPMemberInfo newMember) {
            ownMembersCore.Add(newMember);
            base.AddMember(newMember);
        }
        protected override bool CanPersist {
            get { return !HasAttribute(NonPersistentAttribute.AttributeType); }
        }
    }
}