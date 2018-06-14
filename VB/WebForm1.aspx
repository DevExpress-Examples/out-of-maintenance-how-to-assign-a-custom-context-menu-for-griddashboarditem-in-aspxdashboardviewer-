<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Dashboard.v15.2.Web, Version=15.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<script type="text/javascript">
	    var grid;
        function OnItemWidgetCreated(s, arg) {
            grid = arg.GetWidget();
            var baseFunc = grid.option('onContextMenuPreparing');
            grid.option('onContextMenuPreparing', function (e) {
                if (baseFunc)
                    baseFunc(e);
                else
                    e.items = [];

                if (e.row.rowType === "data") {
                    e.items.push({
                        text: 'Item',
                        onItemClick: function () {
                        }
                    });
                    e.items.push({
                        text: 'SubItems',
                        onItemClick: function () {
                        },
                        items: [{
                            text: 'SubItem',
                            onItemClick: function () {
                            }
                        }]
                    });
                }
            });
        }
	</script>
</head>

<body>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxDashboardViewer ClientInstanceName="viewer" ID="ASPxDashboardViewer1" runat="server"
				DashboardSource="WebApplication1.Dashboard1" Height="600px"
				OnDataLoading="ASPxDashboardViewer1_DataLoading" Width="800px">
				<ClientSideEvents ItemWidgetCreated="OnItemWidgetCreated" />
			</dx:ASPxDashboardViewer>
		</div>
	</form>
</body>
</html>
