using _2._Domain.Exceptions;
using _3._Data.Model;
using _3._Data.Posts;
using _3._Data.Postulations;
using _3._Data.Workers;

namespace _2._Domain.Postulations
{
    public class PostulationDomain : IPostulationDomain
    {
        private IPostulationData _postulationData;
        private IWorkerData _workerData;
        private IPostData _postData;
        public PostulationDomain(IPostulationData postulationData, IWorkerData workerData, IPostData postData)
        {
            _postulationData = postulationData;
            _workerData = workerData;
            _postData = postData;
        }
        public async Task<bool> CreateAsync(Postulation postulation)
        {
            Worker? worker = await _workerData.ExistsByIdAsync(postulation.WorkerId);
            Post? post = await _postData.GetByPostIdAsync(postulation.PostId);

            if(worker == null)
            {
                throw new InvalidWorkerIDException($"Worker with ID {postulation.WorkerId} was NOT found");
            }

            if(post == null)
            {
                throw new InvalidPostIDException($"Post with ID {postulation.PostId} was NOT found");
            }

            bool existsByWorkerIdAndPostId = await _postulationData.ExistsByWorkerIdAndPostIdAsync(postulation.WorkerId, postulation.PostId);
            if(existsByWorkerIdAndPostId)
            {
                throw new AlreadyPostulatedException("You have already applied to this job");
            }

            await _postulationData.CreateAsync(postulation);
            return true;
        }

        public async Task<bool> DeleteAsync(int postulationId)
        {
            var postulationToBeDeleted = await _postulationData.DeleteAsync(postulationId);
            if(postulationToBeDeleted)
            {
                return true;
            }

            throw new InvalidPostulationIDException($"Postulation with ID {postulationId} was NOT found");
        }
    }
}
