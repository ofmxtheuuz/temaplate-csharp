## Descomplicando o  Entity Framework Core
****
<p style="font-size: 20px">
    Primeiramente, devemos criar a intância da AppDbContext
</p>

````csharp 
public class AplicationDbContext()
{ 
    public DbSet<Pessoa> Pessoas { get; set; }
} 
````