/// <reference path="../Definitions/john-smith-latest.d.ts"/> 
/// <reference path="../Scripts/ViewModels.ts"/> 
/// <reference path="JobView.ts"/> 
/// <reference path="_ActivityStatus.ts"/> 

class JobGroupView implements js.IView<JobGroupViewModel> {
    template = "#JobGroupView";

    init(dom: js.IDom, viewModel: JobGroupViewModel) {
        dom('header h2').observes(viewModel.name);
        dom('.status').observes(viewModel, ActivityStatusView2);
        dom('.content').observes(viewModel.jobs, JobView);

        dom('.actions .pause').on('click').react(viewModel.pause);
        dom('.actions .resume').on('click').react(viewModel.resume);

        dom.onUnrender().listen(() => {
            dom.$.fadeOut();
        });
    }
}  