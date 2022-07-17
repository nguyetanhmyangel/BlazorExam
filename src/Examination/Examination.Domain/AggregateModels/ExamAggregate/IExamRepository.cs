using Examination.Domain.SeedWorks;

namespace Examination.Domain.AggregateModels.ExamAggregate;

public interface IExamRepository : IRepositoryBase<Exam>
{
    Task<IEnumerable<Exam>> GetExamListAsync();
    Task<Exam> GetExamByIdAsync(string id);
}