<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myCalculator.aspx.cs" Inherits="myCalculator.myCalculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>

        <style>

        </style>

        <h1>My Personal Calculator</h1>
        <br />

        <tr>
            <td colspan="4">
                <asp:TextBox ID="txtDisplay" Height="30px" runat="server" Width="320px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td><asp:Button ID="btn7" runat="server" Height="35px" Text="7" Width="80px" OnClick="btn7_Click"/></td>
            <td><asp:Button ID="btn8" runat="server" Height="35px" Text="8" Width="80px" OnClick="btn8_Click"/></td>
            <td><asp:Button ID="btn9" runat="server" Height="35px" Text="9" Width="80px" OnClick="btn9_Click"/></td>
            <td><asp:Button ID="btnDivision" runat="server" Height="35px" Text="/" Width="80px" OnClick="btnDivision_Click"/></td>
        </tr>

        <tr>
            <td><asp:Button ID="btn4" runat="server" Height="35px" Text="4" Width="80px" OnClick="btn4_Click"/></td>
            <td><asp:Button ID="btn5" runat="server" Height="35px" Text="5" Width="80px" OnClick="btn5_Click"/></td>
            <td><asp:Button ID="btn6" runat="server" Height="35px" Text="6" Width="80px" OnClick="btn6_Click"/></td>
            <td><asp:Button ID="btnMultiply" runat="server" Height="35px" Text="*" Width="80px" OnClick="btnMultiply_Click"/></td>
        </tr>

        <tr>
            <td><asp:Button ID="btn1" runat="server" Height="35px" Text="1" Width="80px" OnClick="btn1_Click"/></td>
            <td><asp:Button ID="btn2" runat="server" Height="35px" Text="2" Width="80px" OnClick="btn2_Click"/></td>
            <td><asp:Button ID="btn3" runat="server" Height="35px" Text="3" Width="80px" OnClick="btn3_Click"/></td>
            <td><asp:Button ID="btnMinus" runat="server" Height="35px" Text="-" Width="80px" OnClick="btnMinus_Click"/></td>
        </tr>

         <tr>
            <td><asp:Button ID="btn0" runat="server" Height="35px" Text="0" Width="80px" OnClick="btn0_Click"/></td>
            <td><asp:Button ID="btnDot" runat="server" Height="35px" Text="." Width="80px" OnClick="btnDot_Click"/></td>
            <td><asp:Button ID="btnPlus" runat="server" Height="35px" Text="+" Width="80px" OnClick="btnPlus_Click"/></td>
            <td><asp:Button ID="btnEqual" runat="server" Height="35px" Text="=" Width="80px" OnClick="btnEqual_Click"/></td>
        </tr>

    </table>

</asp:Content>
