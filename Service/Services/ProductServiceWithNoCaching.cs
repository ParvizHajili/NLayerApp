using AutoMapper;
using Core.Dtos;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class ProductServiceWithNoCaching : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductServiceWithNoCaching(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();

            var productsDto =_mapper.Map<List<ProductWithCategoryDto>>(products);

            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200,productsDto);
        }
    }
}
