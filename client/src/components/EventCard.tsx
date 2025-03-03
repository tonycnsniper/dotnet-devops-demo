import { Threater } from "../types/threater";

export default function EventCard({ name, location }: Threater) {
  return (
    <div className="rounded-t-lg overflow-hidden p-10 flex justify-center">
      <div className="max-w-sm rounded overflow-hidden shadow-lg">
          <div className=""></div>
          <div className="px-6 py-4">
            <div className="font-bold text-xl mb-2">{ name }</div>
            <p className="text-gray-700 text-base">
              Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque, exercitationem praesentium nihil.
            </p>
          </div>
          <div className="px-6 pt-4 pb-2">
            <span className="inline-block bg-gray-200 rounded-full px-3 py-1 text-sm font-semibold text-gray-700 mr-2 mb-2"># {location}</span>
            <span className="inline-block bg-gray-200 rounded-full px-3 py-1 text-sm font-semibold text-gray-700 mr-2 mb-2">#travel</span>
            <span className="inline-block bg-gray-200 rounded-full px-3 py-1 text-sm font-semibold text-gray-700 mr-2 mb-2">#winter</span>
          </div>
      </div>
    </div>
  );
}
