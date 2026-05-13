namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

	async void VoltarClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//ContratacaoHospedagem");
    } // quando clicar no botão voltar, ele vai para ContratacaoHospedagem
}