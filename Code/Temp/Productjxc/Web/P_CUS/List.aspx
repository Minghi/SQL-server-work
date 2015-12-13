<%@ Page Title="P_CUS" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Productjxc.Web.P_CUS.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>¹Ø¼ü×Ö£º</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="²éÑ¯"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"
                    BorderWidth="1px" DataKeyNames="ProNO,CusNO" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="Ñ¡Ôñ"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="ProNO" HeaderText="ProNO" SortExpression="ProNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CusNO" HeaderText="CusNO" SortExpression="CusNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SaleCount" HeaderText="SaleCount" SortExpression="SaleCount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StaffName" HeaderText="StaffName" SortExpression="StaffName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SalePrice" HeaderText="SalePrice" SortExpression="SalePrice" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="ÏêÏ¸" ControlStyle-Width="50" DataNavigateUrlFields="ProNO,CusNO" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="ÏêÏ¸"  />
                            <asp:HyperLinkField HeaderText="±à¼­" ControlStyle-Width="50" DataNavigateUrlFields="ProNO,CusNO" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
                                Text="±à¼­"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="É¾³ý"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="É¾³ý"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="É¾³ý" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
