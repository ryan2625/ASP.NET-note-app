<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="journal_app._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h2>Your Notes</h2>
        <section>
            <div class="create">
                <div>
                    <div>
                        <label>Name</label>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <label>Description</label>
                        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                    </div>
                </div>
                <asp:Button class="subm-btn" ID="btnSubmit" runat="server" Text="Add" OnClick="handle_add" />
            </div>
            <div class="display">
                <asp:Repeater ID="noteRepeater" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <h3><%# Eval("Name") %></h3>
                                <p><%#Eval("Description") %></p>
                            </div>
                            <div class="btns">
                                <asp:Button class="subm-btn grn" ID="Button1" runat="server" Text="Delete" OnClick="HandleDelete" CommandArgument='<%# Eval("Name") %>' />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </section>
    </main>

</asp:Content>
