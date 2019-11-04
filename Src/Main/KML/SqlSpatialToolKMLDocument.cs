using Microsoft.SqlServer.Types;
using SQLSpatialTools;

namespace USC.GISResearchLab.Common.Core.KML
{


    public class SqlSpatialToolKMLDocument : KMLDocument
    {


        public SqlSpatialToolKMLDocument() : base()

        {
        }

        public SqlSpatialToolKMLDocument(string name) : base(name)
        {


        }



        public void AddSqlGeometry(SqlGeometry sqlGeometry, string name, string styleName, string description)
        {

            SqlGeography sqlGeography = SQLSpatialToolsFunctions.VacuousGeometryToGeography(sqlGeometry, sqlGeometry.STSrid.Value);
            AddSqlGeography(sqlGeography, name, styleName, description);
        }

    }
}
