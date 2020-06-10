using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using Infrastructure;
namespace BLL
{
    public class ProductService
    {
        private readonly ConnectionManager connectionManager;
        private readonly ProductRepository productRepository;

        public ProductService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            productRepository = new ProductRepository(connectionManager);
        }

        public string Save(Product product)
        {
            try
            {
                connectionManager.OpenConnection();
                productRepository.Save(product);
                return $"Producto guardado exitosamente!";
            }
            catch (Exception e)
            {
                return $"Error de aplicacion: {e.Message}";
            }
            finally { connectionManager.CloseConnection(); }

        }

        public ConsultProductAnswer Consult()
        {
            ConsultProductAnswer answer = new ConsultProductAnswer();

            try
            {
                connectionManager.OpenConnection();
                answer.Products = productRepository.Consult();
                answer.Message = (answer.Products.Count() != 0) ? "Se consultaron los productos" : "No hay productos para consultar";
                answer.Error = false;
                return answer;
            }
            catch (Exception e)
            {
                answer.Message = $"Error de aplicacion: {e.Message}";
                answer.Error = true;
                return answer;


            }
            finally { connectionManager.CloseConnection(); }
        }

        public string Remove(string ID)
        {
            try
            {
                connectionManager.OpenConnection();

                return productRepository.Remove(ID) ? $"El producto con ID {ID}, se ha eliminado satisfactoriamente!"
                                                    : $"Lo sentimos, {ID} no se encuentra registrado";
            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally { connectionManager.CloseConnection(); }
        }

        public string Modify(Product product)
        {
            try
            {
                connectionManager.OpenConnection();

                return productRepository.Modify(product) ? $"El registro {product.Name} se ha modificado satisfactoriamente."
                                                         : $"Lo sentimos, {product.ID} no se encuentra registrado.";
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { connectionManager.CloseConnection(); }
        }

        public SearchProductAnswer Search(string ID)
        {
            SearchProductAnswer answer = new SearchProductAnswer();

            try
            {
                connectionManager.OpenConnection();
                answer.Product = productRepository.Search(ID);
                answer.Message = (answer.Product != null) ? "Se encontró la el producto buscado" : "El producto buscado no existe";
                answer.Error = false;
                return answer;
            }
            catch (Exception e)
            {

                answer.Message = $"Error de la Aplicacion: {e.Message}";
                answer.Error = true;
                return answer;
            }
            finally { connectionManager.CloseConnection(); }
        }

        public string GeneratePDF(Invoice invoice, string fileName)
        {
            DocumentPDF documentPDF = new DocumentPDF();

            try
            {
                documentPDF.savePDF(invoice, fileName);
                return "Se genero el PDF corectamente!";
            }
            catch (Exception e)
            {

                return $"Error al crear documento {e.Message}";
            }
        }
    }



    public class ConsultProductAnswer
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public IList<Product> Products { get; set; }
    }


    public class SearchProductAnswer
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public Product Product { get; set; }
    }




}
